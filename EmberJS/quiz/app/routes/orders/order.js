import Ember from 'ember';

export default Ember.Route.extend({
  model(params) {
    const id = params.order_id;
    const store = this.get('store');
    return store.getOrderById(id);
  },

  store: Ember.inject.service('store')
});
