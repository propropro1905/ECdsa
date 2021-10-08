  pipeline {
    agent any
    stages{
      stage('Build'){
        steps{
             sh 'dotnet build ECDSA/ECDSA.sln --configuration Release --no-restore'
        }
      }
    }
}
