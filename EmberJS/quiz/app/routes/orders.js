import Ember from 'ember';

export default Ember.Route.extend({
  model() {
    const store = this.get('store');
    return store.getOrders();
  },

  store: Ember.inject.service('store')
});
