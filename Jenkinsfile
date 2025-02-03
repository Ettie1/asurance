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
            sh 'suso apt-get install dotnet&&dotnet --version'
          }
        }

      }
    }

  }
}