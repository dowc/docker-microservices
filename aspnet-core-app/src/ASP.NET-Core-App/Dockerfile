# Base of your container
FROM microsoft/aspnet:1.0.0-rc1-update1-coreclr

# Copy the project into folder and then restore packages
COPY . /aspnet-core-app
WORKDIR /aspnet-core-app
RUN ["dnu","restore"]

# Open this port in the container
EXPOSE 3002
# Start application
ENTRYPOINT ["dnx" , "web"]