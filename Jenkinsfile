  pipeline {
    agent any
    stages{
      stage('Build'){
        steps{
             sh '$HOME/.dotnet/dotnet build ECDSA/ECDSA.sln --configuration Release --no-restore'
        }
      }
    }
}
