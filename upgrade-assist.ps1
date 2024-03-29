dotnet tool install -g upgrade-assistant

$proyectos = Get-ChildItem -Path "./" -Recurse -Filter "*.csproj"

foreach ($proyecto in $proyectos) 
{
    Write-Host "Update $($proyecto.FullName)" -ForegroundColor Green

    upgrade-assistant upgrade $proyecto.FullName 
}