pipeline {
  agent any
  stages {
    stage('Restore CLI') {
      parallel {
        stage('Restore CLI') {
          steps {
            dotnetRestore(sources: 'nuget.org', runtimes: 'win-x64', project: 'NumberCombinationGeneratorCli')
          }
        }

        stage('Restore WebApp') {
          steps {
            dotnetRestore(project: 'NumberCombinationGenerator', sources: 'nuget.org', runtime: 'win-x64')
          }
        }

      }
    }

    stage('Build CLI') {
      parallel {
        stage('Build CLI') {
          steps {
            dotnetBuild(options: ' ', targets: ' ', runtime: 'win-x64', project: 'NumberCombinationGeneratorCli', noRestore: true)
          }
        }

        stage('Build WebApp') {
          steps {
            dotnetBuild(project: 'NumberCombinationGenerator', runtime: 'win-x64', noRestore: true)
          }
        }

      }
    }

    stage('Test') {
      steps {
        dotnetTest(project: 'NumberCombinationGenerator.Tests')
      }
    }

    stage('Publish') {
      steps {
        dotnetPublish(project: 'NumberCombinationGeneratorCli', configuration: 'Release', selfContained: true, noBuild: true, runtime: 'win-x64')
      }
    }

  }
}