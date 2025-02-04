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
            sh 'cp . /var/jenkins_home/workspace/'
            dotnetBuild(charset: 'utf8')
          }
        }

      }
    }

  }
}