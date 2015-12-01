# Week-7-Day-2
I love you, MVC.

# Intro to ASP.NET MVC


## Today

* Excetions (gotta catch 'em all!) 
* Intro to MVC
* MVC - Models

## Homework

1. Fork this repo and clone the fork. 
2. Create a MVC app (without authenication enabled) in Visual Studio
1. Add some text from your favorite ipsum (lorem, bacon, samuel-l, hipster, church) to the "/home/index" page (any where on the page that you would like)
1. Create a page with a url of "/classmates/list"
  1. This page will List your classmates names along with their hair color and height.
  2. This will require creating a ClassmateVM class in your Model Folder.
  3. Your view for "/classmates/list" will have a model of List<ClassmateVM>
  4. Add a foreach loo to the view to iterate through the model
5. Create page with a url of "/classmate/PostWallMessage"
  6. This page will allow you to enter your name and the message you want to post on the wall.
  7. After posting the page return the person's name and the message they wrote back to the user. It's not required to save this message.
  8. Hint* Right Click on the action in the controller -> Add View -> Template: Create
1. Submit a pull request to your forked repo.

### Hard Mode

1. Create a vanity url that points "/students" to "/classmates/list"
  2. Hint - Check out the RouteConfig.cs file to add url routes

### Nightmare Mode

1. Store your classmates and the messages that are posted to a database.
  2. Hint - add entity framework as a nuget package and add a DBContext to your project (right click models -> Add New -> ADO.NET Enity Model -> Empty Code First Model)
