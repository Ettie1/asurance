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
            sh 'cd ..&&cp asurance /var/jenkins_home/workspace/'
            dotnetBuild(charset: 'utf8')
          }
        }

      }
    }

  }
}