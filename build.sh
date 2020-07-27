#!/usr/bin/env bash
##########################################################################
# This is the Cake bootstrapper script for Linux and OS X.
# This file was downloaded from https://github.com/cake-build/resources
# Feel free to change this file to fit your needs.
##########################################################################

# Define directories.
SCRIPT_DIR=$( cd "$( dirname "${BASH_SOURCE[0]}" )" && pwd )
TOOLS_DIR=$SCRIPT_DIR/tools
DOTNET_VERSION=3.1.302
CAKE_VERSION=0.38.4
CAKE_DLL=$TOOLS_DIR/Cake.Tool.$CAKE_VERSION/tools/netcoreapp3.0/any/Cake.dll
NUGET_EXE=$TOOLS_DIR/nuget.exe

###########################################################################
# Make sure the tools folder exist
###########################################################################
if [ ! -d "$TOOLS_DIR" ]; then
  mkdir "$TOOLS_DIR"
fi

###########################################################################
# Make sure that packages.config exist.
###########################################################################
if [ ! -f "$TOOLS_DIR/packages.config" ]; then
    echo "Downloading packages.config..."
    curl -Lsfo "$TOOLS_DIR/packages.config" https://cakebuild.net/download/bootstrapper/packages
    if [ $? -ne 0 ]; then
        echo "An error occurred while downloading packages.config."
        exit 1
    fi
fi

###########################################################################
# INSTALL .NET CORE CLI
###########################################################################

#echo "Installing .NET CLI..."
#if [ ! -d "$SCRIPT_DIR/.dotnet" ]; then
#  mkdir "$SCRIPT_DIR/.dotnet"
#fi
#sudo apt-get install libunwind8
#curl -Lsfo "$SCRIPT_DIR/.dotnet/dotnet-install.sh" https://raw.githubusercontent.com/dotnet/cli/rel/1.0.0/scripts/obtain/dotnet-install.sh
#sudo bash "$SCRIPT_DIR/.dotnet/dotnet-install.sh" --version $DOTNET_VERSION  --install-dir .dotnet --no-path
#export PATH="$SCRIPT_DIR/.dotnet":$PATH
#export DOTNET_SKIP_FIRST_TIME_EXPERIENCE=1
#export DOTNET_CLI_TELEMETRY_OPTOUT=1
#"$SCRIPT_DIR/.dotnet/dotnet" --info


###########################################################################
# INSTALL CAKE
###########################################################################

if [ ! -f "$CAKE_DLL" ]; then
    curl -Lsfo Cake.Tool.zip "https://www.nuget.org/api/v2/package/Cake.Tool/$CAKE_VERSION" && unzip -q Cake.Tool.zip -d "$TOOLS_DIR/Cake.Tool.$CAKE_VERSION" && rm -f Cake.Tool.zip
    if [ $? -ne 0 ]; then
        echo "An error occured while installing Cake."
        exit 1
    fi
fi

# Make sure that Cake has been installed.
if [ ! -f "$CAKE_DLL" ]; then
    echo "Could not find Cake.exe at '$CAKE_DLL'."
    exit 1
fi

###########################################################################
# RUN BUILD SCRIPT
###########################################################################

# Start Cake
exec dotnet "$CAKE_DLL" "$@"