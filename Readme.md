# Monolith Service 
This service is a demonstration of moving from a monolithic code base to a more microservices based architecture. 

This is paired up with the repo: http://github.com/r3adm3/multiservice

## Compiling in Development

Clone the repo. Ensure .Net 5.0 is installed. 

```dotnetcore
dotnet run
```

Test should be able to be run using a browser, and going to http://localhost:5000

## Making a docker image

Included in the project is a Dockerfile which will create a docker image artifact, change into the source code directory and type:

```docker
docker build -t mysvc/monolith:v1 .
```

To run a container of this image:

```docker (production)
docker container run --name test_monolith -p 18080:80 mysvc/monolith:v1
```

```docker (development)
docker container run -e ASPNETCORE_ENVIRONMENT='Development' --rm --name test_monolith -p 18080:80 mysvc/monolithsvc:v1
```
Test should be able to be run using a browser, and going to http://localhost:18080

## Status

| service | CI tested | Docker Reg Upload |
| ----------- | ----------- | ----------- |
| monolithsvc |[![Build status](https://techfrontier.visualstudio.com/dockerOrchestrationExperiment/_apis/build/status/monolithsvc/1.%20compile%20and%20test%20(mono))](https://techfrontier.visualstudio.com/dockerOrchestrationExperiment/_build/latest?definitionId=13)|[![Build status](https://techfrontier.visualstudio.com/dockerOrchestrationExperiment/_apis/build/status/monolithsvc/2.%20docker%20build%20(mono))](https://techfrontier.visualstudio.com/dockerOrchestrationExperiment/_build/latest?definitionId=12)|

---  

| release | environment | env | tested | Date
| ----------- | ----------- | ----------- | ----------- | ----------- |
| agnolotti | docker container run --name test_monolith -p 18080:80 monolithsvc | docker toolbox - win | success | 2021-03-17
| agnolotti | docker container run --name test_monolith -p 18080:80 monolithsvc | docker desktop - mac | success | 2021-03-17
