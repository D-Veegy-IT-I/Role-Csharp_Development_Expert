### Note: How to collapse all regions properly:

#### Sub-note: Enable collapsing regions properly

- Go to Tools > Options > Text Editor > C# > Advanced > Outlining 

- Check "`Collapse #regions when collapsing to definitions`"

#### Sub-note: Collapsing and Expand regions

- Perform "collapsing to definitions" by pressing `[CTRL + M]` and `[CTRL + O]`

- Perform "expanding to definitions" by pressing `[CTRL + M]` and `[CTRL + P]`

#### Manager-Factory relation:

* Product-Factory-Manager concept: 
  - The creation and governance of a class (product) are 
    separate (SoC) and thereby dependency-inversed (DIP)
  * Note: The Factory instantiates the Manager, 
    of which the Manager makes sure this is done correctly
* Standalone methods encapsulate & insulate singular intentions
