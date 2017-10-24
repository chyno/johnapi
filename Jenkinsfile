pipeline {
  agent {
    dockerfile {
      filename 'Dockerfile'
    }
    
  }
  stages {
    stage('Get Code') {
      steps {
        git(url: 'https://github.com/chyno/johnapi.git', poll: true, changelog: true, branch: 'master', credentialsId: 'github')
      }
    }
    stage('') {
      steps {
        echo 'About to run tests'
      }
    }
  }
}