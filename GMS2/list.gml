//ds_list = Data Structure List
// This takes up its own slot in memory
var list = ds_list_create();

//Need to have them destroy to free up memory, not built in garbage collector for ds_list
ds_list_destroy(_instList);

//We can just use array

