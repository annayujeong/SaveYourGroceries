## SaveYourGroceries

## SaveYourGroceriesLib
### Get newly updated price of the items in saved items list
This has been automated by Jenkins, scheduled every <time>
#### Jenkins
##### Before setup
**IMPORTANT!** Open .sln in VS and update MSTest.TestAdapter and MSTest.TestFramwork to the latest version for SaveYourGroceriesLib
##### How to setup Jenkins?
- Follow https://www.jenkins.io/doc/book/installing/war-file/ to setup
- Contact Anna for admin password
##### How to setup MSBuild?
- Follow https://plugins.jenkins.io/msbuild/
##### How to run Jenkins?
- in CLI: java -jar C:\Users\yujeo\Documents\Selenium\exe\jenkins.war
- Go to localhost:8080 (by default)
##### How to configure* the project?
- Go to Dashboard - SaveYourGroceries - Configure - Scroll down to Build Steps
- Click Add build steps - Build a Visual Studio project or solution using MSBuild
  - MSBuild Version
      - one you specified in above step
  - MSBuild Build File
      - static path* to SaveYourGroceries.sln
- Click Add build steps - Execute Windows batch command
  - Command
      - ``dotnet vstest <static-path-to-SaveYourCroceriesLib.dll>``
- Save
##### How to run?
- Manually
  - Dashboard - SaveYourGroceries project - Build Now
- Scheduled
  - Currently it is setup every <time>
  - To reschedule, 
##### How to check result?
- Dashboard - SaveYourGroceries project - Click the build name you ran
  - The icon will indicate either success or fail
- In case of fail, you might want to check console
  - Go to Console Output and scroll down to see error message and stack trace

configure*
- We currently use local project folder to run the script since the saved item list json file will be on Appdata/roaming
- If we have the file under solution directory, Jenkins can be run on Github directly, and this will be stable since it has the latest code

static path*
- we use static path for now - relative path can be specified using Jenkins global env var, this is next step
