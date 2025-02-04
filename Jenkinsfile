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
            dotnetBuild(charset: 'utf8')
            sh 'cd ..&&cp asurance /var/jenkins_home/workspace/'
          }
        }

      }
    }

  }
}