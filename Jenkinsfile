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
            sh 'sudo apt install dotnet --classic&&dotnet --version'
          }
        }

      }
    }

  }
}