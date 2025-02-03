pipeline {
  agent any
  stages {
    stage('ListAll') {
      parallel {
        stage('ListAll') {
          steps {
            sh 'ls -ltra'
          }
        }

        stage('CheckForDotNet') {
          steps {
            sh 'apt install dotnet&&dotnet --version'
          }
        }

      }
    }

  }
}