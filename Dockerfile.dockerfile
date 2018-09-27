#Dockerfile creating image to test cake building script on ubuntu

FROM ubuntu:18.04

#Updete and upgrade
RUN apt-get update
RUN apt-get upgrade

RUN apt-get install wget apt-transport-https git curl nano mono gnupg

#Install .NET core (2.1) and mono 
RUN wget -q https://packages.microsoft.com/config/ubuntu/18.04/packages-microsoft-prod.deb
RUN pkg -i packages-microsoft-prod.deb

RUN apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF
RUN echo "deb https://download.mono-project.com/repo/ubuntu stable-bionic main" | tee /etc/apt/sources.list.d/mono-official-stable.list

RUN apt-get update

RUN apt-get install mono-devel

RUN apt-get install dotnet-sdk-2.1

#Clone repo
RUN mkdir /home/repos
RUN git clone https://github.com/Carlj28/RickAndMorty.Net.Api /home/repos/


# Adjust the permissions for the bootstrapper script.
RUN chmod +x /home/repos/build.sh