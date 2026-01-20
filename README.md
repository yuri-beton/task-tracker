# Task Tracker
Technical document - https://roadmap.sh/projects/task-tracker  

## Requirements
Dotnet 9.0+

## Installation
1. Clone repository by
```
git clone git@github.com:yuri-beton/task-tracker.git
```
2. Move to project folder
```
cd task-tracker
```
3. Build project
```
dotnet publish -c Release -r win-x64 --self-contained true /p:PublishSingleFile=true
```
4. Add bin/Release/net8.0/win-x64/publish/ to Path. You can also move task-tracker.exe to C:\tools and then add to Path.

### Example
```
# Adding a new task
task-tracker add "Buy groceries"
# Output: Task added successfully (ID: 1)

# Updating and deleting tasks
task-tracker update 1 "Buy groceries and cook dinner"
task-tracker delete 1

# Marking a task as in progress or done
task-tracker mark-in-progress 1
task-tracker mark-done 1

# Listing all tasks
task-tracker list

# Listing tasks by status
task-tracker list done
task-tracker list todo
task-tracker list in-progress
```
