#!/bin/bash

# Path to the folder containing all projects
PROJECTS_DIR="C:\Users\gamev\Desktop\EXAMWORK"

# GitHub username
GITHUB_USERNAME="CRWLRZBL"

# Change to the projects directory
cd "$PROJECTS_DIR" || exit

# Iterate over each project directory
for project in */; do
    # Remove the trailing slash from the project name
    project_name="${project%/}"
    
    # Create a new GitHub repository
    gh repo create "$GITHUB_USERNAME/$project_name" --public --confirm
    
    # Initialize git, add remote, and push to GitHub
    cd "$project_name" || continue
    git init
    git remote add origin "https://github.com/$GITHUB_USERNAME/$project_name.git"
    git add .
    git commit -m "Initial commit"
    git branch -M main
    git push -u origin main
    
    # Go back to the parent directory
    cd ..
done