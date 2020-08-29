# Johnfg2610.Stockit - ASP.NET Core 3.1 Server

Used to access inventory counts as well as brands and catalog items

## Run

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```
## Run in Docker

```
cd src/Johnfg2610.Stockit
docker build -t johnfg2610.stockit .
docker run -p 5000:8080 johnfg2610.stockit
```
