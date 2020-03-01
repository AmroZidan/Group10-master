**Program Organization**
--------------------------

Context
----------------------------

![Context](https://github.com/bquiroga10/Group10/blob/master/artifacts/architecture/ContextDiagram.png)

Container
----------------------------

![Diagram 1](https://github.com/bquiroga10/Group10/blob/master/artifacts/architecture/ArchitecturalDiagram.png)

![Sequence](https://github.com/bquiroga10/Group10/blob/master/artifacts/architecture/SequenceDiagram.png)

**Code Design**
-------------------------

![Class diagram](https://github.com/bquiroga10/Group10/blob/master/artifacts/architecture/ClassDiagram.PNG)

**Data Design**
-------------------------

We are using the Open Trivia Database as the source for our game's questions, so the only data storage necessary will be for holding questions locally during the game. We can keep the questions we pull in shuffled lists based on their difficulty, and poll the corresponding list for a question when the player should receive one.

**Buisness Rules**
------------------------

As we are using the free version of Unity, we cannot exceed $100,000 of funding in a 12 month period.

There aren't any major business concerns that would alter the core functionality of our project.

**User Interface Diagram**
------------------------

![First](https://github.com/bquiroga10/Group10/blob/master/artifacts/architecture/UserInterface.png)

![Second](https://github.com/bquiroga10/Group10/blob/master/artifacts/architecture/User%20Interface%20Diagram.png)


**Resource Management**
------------------------

Since we are using Open Trivia DB, resource management is not a major factor in our build; we are only subject to the restrictions imposed by that database. (Namely, we can not query more than 50 questions at a time.) We can repeat several of these queries; only a single lightweight connection will be required for the end user.

**Security**
-------------------------

Since our game will only be played by a single client, and will require no storage of personal data, the security risks associated with our application are very low. We will be using Unity's libraries for generating requests to the database. The only special piece of information is the API key used to make requests; since these can be regenerated at will, it is very low priority.

**Performance**
------------------------

 Since we are starting with a 2D sprite/environment, the graphical requirements of the initial build of our project are unlikely to require resource-intensive processing. Performance should not be a big issue.

**Scalability**
------------------------

Only one user will ever be playing, so scalability is not an issue. The objective throughout development will be focused on optimizing the performance for a single player.

**Interoperability**
------------------------

This is a single player game which only takes in data through API requests. Aside from basic libraries associated with those requests, we do not need to consider interoperability; we will rely on Unity's resource management with the rest of the player's operating system..

**Internationalization/Localization**
------------------------

As this game is very text heavy, we have no plans to localize this game into other languages.

**Input/Output**
------------------------

Despite being a video game, there is an input/output field with regards to reading and printing out the questions. The input will be from open unity DB, and it will parse the input into the text boxes within Unity.

**Error Processing**
------------------------

Most of the errors within the video game will be handled within Unity. The errors in regards to pulling from Open Trivia DB will have to be done manually.

**Fault Tolerence**
------------------------

We will make the question retrieval process resilient to unexpected situations (i.e. a nonresponsive API, empty response, etc.) and provide an error or wait system to the user while retrying. We will run tests regularly to ensure that other areas of our project are resilient to errors as well.

**Architectural Feasibility**
------------------------------

Since the scope of our game is well inside that of many widely availably Unity games, as well as many projects shared by our team's peers, the feasibility of a Unity project is well understood to be reasonable.

**Overengineering**
------------------------------

Through regular communication, good documentation, and clear/concise variable/function names, our team will keep tabs on what code we have available to accomplish what tasks. In this way we will limit the amount of redundant code we write, keeping down overengineering.

**Build-vs-Buy Decisions**
------------------------------

Unity has quite a bit of free assets in the unity store, as well as using Open Trivia DB. These should be sufficient for filling out the majority of our project requirements.

**Reuse**
-----------------------------

A lot of what unity offers can be considered 'pre existing software' that we utilize while creating the game. Tile generation, pre existing assets that we can import from the asset store and use and collider physics to name a few  are all unity software options that unity offers that we can use and reuse freely.

**Change Strategy**
-----------------------------

Since all Unity projects are broken into smaller scenes. Throughout the designing process, If we need to change or add to a certain aspect of the project, we can simply go to the corresponding scene and edit it or add to it. Managing and editing scenes, whether its changing unity sprite settings (Position, scaling, sprite renderer, rigid body) or editing the coding script (for example, movement behaviour), all can be done easily by just clicking on the scene we wish to change and easily make changes to it. This becomes a simple, efficient and error free process thanks to Unity's way of organizing a project into well ordered sub-projects.
