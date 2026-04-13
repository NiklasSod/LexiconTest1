param(
    [Parameter(Mandatory=$true)]
    [string]$RemoteUrl
)

# Initialize git if not already
if (-not (Test-Path .git)) {
    git init
    git add .
    git commit -m "Initial commit"
} else {
    Write-Host "Git already initialized."
}

# Add remote and push
try {
    git remote add origin $RemoteUrl -ErrorAction Stop
} catch {
    Write-Host "Remote 'origin' already exists. Updating URL."
    git remote set-url origin $RemoteUrl
}

# Push to remote
git branch -M main
git push -u origin main

Write-Host "Connected to GitHub repository: $RemoteUrl"