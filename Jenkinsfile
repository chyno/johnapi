pipeline {
  agent any
  stages {
    stage('Get Code') {
      steps {
        git(url: 'https://github.com/chyno/johnapi.git', poll: true, changelog: true, branch: 'master', credentialsId: 'github')
      }
    }
    stage('') {
      steps {
        sh 'docker build .'
      }
    }
  }
}