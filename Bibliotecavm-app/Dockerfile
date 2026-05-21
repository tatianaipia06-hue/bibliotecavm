# Usa la imagen oficial de Microsoft con Windows Server y IIS para .NET Framework
FROM mcr.microsoft.com/dotnet/framework/aspnet:4.7.2-windowsservercore-ltsc2019

# Establece la carpeta de trabajo dentro del servidor virtual
WORKDIR /inetpub/wwwroot

# Copia los archivos publicados de tu proyecto a la carpeta del servidor IIS
COPY ./Bibliotecavm-app/Presentation/bin/Release/Publish/ .