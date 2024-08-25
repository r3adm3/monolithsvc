# Monolith Service
...(check gpg deck)...
This service is a demonstration of moving from a monolithic code base to a more microservices based architecture.

This is paired up with the repo: <http://github.com/r3adm3/multiservice>

## Compiling in Development

Clone the repo. Ensure .Net 8.0 is installed.

```dotnetcore
dotnet run
```

Test should be able to be run using a browser, and going to <http://localhost:5000>

## Testing the code

Running the Unit Tests

```dotnetcore
cd monolithsvc.PlaywrightTests
dotnet test
```

Running the Playwright Tests


```dotnetcore
cd monolithsvc.Tests
dotnet test
```
## Making a docker image

Included in the project is a Dockerfile which will create a docker image artifact, change into the source code directory and type:

```docker
docker build -t mysvc/monolith:v1 .
```

To run a container of this image:

```docker (production)
docker container run --name test_monolith -p 18080:8080 mysvc/monolith:v1
```

```docker (development)
docker container run -e ASPNETCORE_ENVIRONMENT='Development' --rm --name test_monolith -p 18080:8080 mysvc/monolithsvc:v1
```

Test should be able to be run using a browser, and going to <http://localhost:18080> if you want to hit the container website

## Status

| service | CI tested | Docker Reg Upload |
| ----------- | ----------- | ----------- |
| monolithsvc |[![Build status](https://techfrontier.visualstudio.com/dockerOrchestrationExperiment/_apis/build/status/monolithsvc/1.%20compile%20and%20test%20(mono))](https://techfrontier.visualstudio.com/dockerOrchestrationExperiment/_build/latest?definitionId=13)|[![Build status](https://techfrontier.visualstudio.com/dockerOrchestrationExperiment/_apis/build/status/monolithsvc/2.%20docker%20build%20(mono))](https://techfrontier.visualstudio.com/dockerOrchestrationExperiment/_build/latest?definitionId=12)|

---  

Current Version

| release | environment | env | Date | status
| ----------- | ----------- | ----------- | ----------- | ----------- |
| halloumi | docker container run --name test_monolith -p 18080:8080 daed.duckdns.org:50000/monolithsvc:halloumi | docker desktop - win | 2023-10-02 | success
| halloumi | docker container run --name test_monolith -p 18080:8080 daed.duckdns.org:50000/monolithsvc:halloumi | docker desktop - mac | 2023-10-02 | success

Previous Versions

| release | environment | env | Date | status
| ----------- | ----------- | ----------- | ----------- | ----------- |
| halloumi-dev | docker container run --name test_monolith -p 18080:8080 daed.duckdns.org:50000/monolithsvc:halloumi-dev | docker toolbox - win | 2023-10-xx | fail *
| halloumi-dev | docker container run --name test_monolith -p 18080:8080 daed.duckdns.org:50000/monolithsvc:halloumi-dev | docker desktop - win | 2023-10-01 | success
| halloumi-dev | docker container run --name test_monolith -p 18080:8080 daed.duckdns.org:50000/monolithsvc:halloumi-dev | docker desktop - mac | 2023-10-01 | success
| Jarlsberg | docker container run --name test_monolith -p 18080:80 monolithsvc | docker toolbox - win | 2023-09-30 | success
| Jarlsberg | docker container run --name test_monolith -p 18080:80 monolithsvc | docker desktop - mac | 2023-09-30 | success
| Jarlsberg-dev | docker container run --name test_monolith -p 18080:80 monolithsvc | docker toolbox - win | 2023-09-30 | success
| Jarlsberg-dev | docker container run --name test_monolith -p 18080:80 monolithsvc | docker desktop - mac | 2023-09-30 | success
| Infossato-dev | docker container run --name test_monolith -p 18080:80 monolithsvc | docker toolbox - win | | success | 
| Infossato-dev | docker container run --name test_monolith -p 18080:80 monolithsvc | docker desktop - mac | 2021-03-17 | success

* Note - Docker Toolbox now errors with the container built using .NET, had to upgrade to Docker Desktop on Windows

*halloumi*

