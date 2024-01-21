# gestistate

> Generated with Smusdi.Templates - smusdi-service
> 
> The *appsettings* folder contains default settings file to be updated and/or moved into an external repository

## Docker build

- publish .NET app
    ```
    dotnet publish -r alpine-x64 -c Release --self-contained true -o publish
    ```
- Dockerfile
    ```
    FROM alpine:3.16

    RUN apk add --no-cache libstdc++ libintl icu

    COPY publish ./
    # COPY appsettings ./

    ENTRYPOINT ["./MyService.Service"]
    ```

## To try in order to limit the image size...
- publish as single file trimmed and compressed
    ```
    dotnet publish -r alpine-x64 -c Release --self-contained true -o publish -p:PublishSingleFile=true -p:PublishTrimmed=true -p:EnableCompressionInSingleFile=true
    ```
- try without **icu** by setting runtime environment variable **DOTNET_SYSTEM_GLOBALIZATION_INVARIANT** to 1; 

> Issue with [serilog](https://github.com/serilog/serilog-settings-configuration/issues/244)