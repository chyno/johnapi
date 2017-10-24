pipeline {
  agent {
    dockerfile {
      filename 'dockerfile'
    }
    
  }
  stages {
    stage('Get Code') {
      steps {
        git(url: 'https://github.com/chyno/johnapi.git', poll: true, changelog: true, branch: 'master', credentialsId: 'github')
        echo '"Hello World"'
      }
    }
  }
}