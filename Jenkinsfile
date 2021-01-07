pipeline {
  agent any
  stages {
    stage('Restore') {
      steps {
        bat 'dotnet restore'
      }
    }

    stage('Build') {
      steps {
        bat 'dotnet build --no-restore'
      }
    }

    stage('Test') {
      steps {
        dotnetTest(project: 'NumberCombinationGenerator.Tests')
      }
    }

    stage('Publish') {
      steps {
        bat 'dotnet publish --self-contained'
      }
    }

  }
}