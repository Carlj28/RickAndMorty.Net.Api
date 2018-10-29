#Dockerfile creating image to test cake building script on ubuntu

FROM ubuntu:18.04

LABEL version="1.0"
LABEL owner="Bartosz Ziółkowski"
LABEL maintainer="Bartosz Ziółkowski"
LABEL organization="Bartosz Ziółkowski"
LABEL description="Image with .NET Core SDK to build."

#Updete and upgrade
RUN apt-get -y update
RUN apt-get -y upgrade

RUN apt-get -y install wget apt-transport-https git curl nano gnupg unzip

#Install .NET core (2.1)
RUN wget -q https://packages.microsoft.com/config/ubuntu/18.04/packages-microsoft-prod.deb
RUN dpkg -i packages-microsoft-prod.deb

RUN apt-get install apt-transport-https
RUN apt-get -y update

RUN apt-get -y install dotnet-sdk-2.1

#Clone repo
RUN mkdir /home/repos
RUN git clone https://github.com/Carlj28/RickAndMorty.Net.Api /home/repos/


# Adjust the permissions for the bootstrapper script.
RUN chmod +x /home/repos/build.sh