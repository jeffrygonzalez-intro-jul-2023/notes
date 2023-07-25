GET /todo-list -> Create an instance of the TodoListController, and call the GetTodoList method.
	- EVERY request duplicates this process. Every request to GET /todo-list gets a BRAND NEW instance of the controller.

.NET Apis are CONCURRENT - they can handle X number of simultaenous requests at the same time.

## JSON Documents

They can contain just one thing:

- A number `3.1415` - no difference between floating point, integer, whatever.
- A string `"tacos are delicious"` - just one string
- The value for a boolean - `"true"` or `"false"`
- the value `null`
- An object `{}`
- An Array `[]`



## Refactoring our API Response.

> I almost NEVER return anything other than an Object from a HTTP response.


```json
{
 "list": [
        {
            "id": "1b68c154-8b40-4ff0-b9f2-3ec10dc55063",
            "description": "Get Beer",
            "status": "Now"
        },
        {
            "id": "806ac470-982b-4f52-9397-0cc112d5ca51",
            "description": "Clean Garage",
            "status": "Waiting"
        }
    ]
}

```