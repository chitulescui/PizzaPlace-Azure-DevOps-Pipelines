# PizzaPlace-DevOps-Nexus

TODO: YAML files for CI/CD pipelines specially developed for Azure DevOps services. 

# Getting Started
TODO: Execute the following steps in order to import or duplicate this repository. 
1. Clone this repository locally.
   ```
        git clone https://github.com/chitulescui/PizzaPlace-Azure-DevOps-Pipelines.git
   ```
2. Clone this repository to your Azure DevOps own repository.
   ```
        git clone --bare https://github.com/EXAMPLE-USER/OLD-REPOSITORY.git
   ```
    Mirror Push to Another repository:
   ```
        cd OLD-REPOSITORY.git
        git push --mirror https://github.com/EXAMPLE-USER/NEW-REPOSITORY.git
   ```
    Remove the temporary local repository you created earlier
   ```  cd ..
        rm -rf OLD-REPOSITORY.git
   ```

# Create repositories
1. Create one repository for each project (BasketMS, CatalogMS, DesktopApp, IdentityMS, WebApp) 
# Build, Restore and Publish
TODO: Create your CI pipelines to restore/build your .csproj file or publish your artifacts to $(Build.ArtifactsStagingDirectory) using the proper YML file from CI_Pipeline folder
1. Build & Restore 
   Create your pipeline based on CI_Build_Restore_Pipeline_AllAps.yml file. The YAML is designed to let you choose the application from a dropdown menu and it executes the commands only on that repository.
2. Build & Publish
   Create your pipeline based on CI_Build_Publish_Pipeline_AllAps.yml file. The YAML is designed to let you choose the application from a dropdown menu and it executes the commands only on that repository. 
# Download artifacts and deploy to Azure Portal 
TODO: Create your CD pipelines to  publish your WebApp or DesktopApp directly to Azure Portal (User has to change the subscription details and working folders specified in YML file)
1. Download & Push to Azure Portal - **WebApp**
Create your pipeline based on CD_Pipeline_WebApp.yml file. Change your Azure Subscription and paths accordingly.
2. Download & Push to Azure Portal - **DesktopApp**
Desktop app was packed before using velopack feature.
Create your pipeline based on CD_Pipeline_DesktopApp.yml file. Change your Azure Subscription and paths accordingly
# Run Docker containers for each application
Docker image file was configured for each project. 
Ports exposed: 
1. BasketMS : 8080
2. CatalogMS : 8081
3. DesktopApp : 8082
4. IdentityMS : 8083
5. WebApp : 8084


Run docker containers with the following comand:
```
docker compose up --build
```
