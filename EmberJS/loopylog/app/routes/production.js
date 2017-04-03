import Ember from 'ember';
const Promise = Ember.RSVP.Promise;

export default Ember.Route.extend({
  model() {
  return new Promise(function(resolve) {
      setTimeout(function() {
        resolve(true);
      }, 2000);
    });
  }
});
