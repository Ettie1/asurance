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
            sh 'snap install dotnet --classic&&dotnet --version'
          }
        }

      }
    }

  }
}