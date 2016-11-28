FROM	ubuntu:16.04

RUN	apt-get update && \
	apt-get install -y apt-transport-https

RUN	sh -c 'echo "deb [arch=amd64] https://apt-mo.trafficmanager.net/repos/dotnet-release/ xenial main" > /etc/apt/sources.list.d/dotnetdev.list' && \
	apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 417A0893 && \
	apt-get update && \
	apt-get install -y dotnet-dev-1.0.0-preview2.1-003177

ADD	start.sh /start.sh

RUN	chmod +x /start.sh

EXPOSE	5000

CMD	["/start.sh"]

#The application will be initialized in /dotnet

