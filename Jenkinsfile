pipeline {
  agent any
  stages {
    stage('Env Checks') {
      steps {
        sh '''
          echo Test Script
          pwd
          ls -R'''
      }
    }

    stage('monolithsvc docker build'){
      steps{
        sh '''cd monolithsvc
        docker login lin-nexus-001.local:8123 -u admin -p wawnab-wivkir-wapvA4
        cp ../nuget.config.nexus ./
        docker build -f ./Dockerfile.nexus -t lin-nexus-001.local:8123/mono:latest .'''
        }
    }

    stage('monolithsvc docker push'){
      steps{
        sh '''
        docker push lin-nexus-001.local:8123/mono:latest'''
        }
    }


  }
}