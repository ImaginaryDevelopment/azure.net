// Code goes here
var total = 0;
var userinput = null;
var lastinput = 0;
var lastoperation = function () {
    return 0;
};
var loaded = new Date().toString();
Ember.LOG_BINDINGS = true;

App = Ember.Application.create({
    LOG_TRANSITIONS: true,
    rootElement: '#emberroot'
});
Ember.onerror = function (error) {
    console.log('error');
    console.log(error);

};
console.log(App);

App.Person = Ember.Object.extend({
    firstName: null,
    lastName: null,

    fullName: function () {
        return this.get('firstName') +
               " " + this.get('lastName');
    }.property('firstName', 'lastName')
});


console.log("Person defined");

App.IndexRoute = Ember.Route.extend({
    model: function () {
        var people = [
          App.Person.create({
              firstName: "Tom",
              lastName: "Dale"
          }),
          App.Person.create({
              firstName: "Yehuda",
              lastName: "Katz"
          })
        ];
      
        return { people: people };
    }
});