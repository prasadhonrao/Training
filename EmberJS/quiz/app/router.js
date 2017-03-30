import Ember from 'ember';
import config from './config/environment';

const Router = Ember.Router.extend({
  location: config.locationType,
  rootURL: config.rootURL
});

Router.map(function() {
  this.route('index', {path: '/'});
  this.route('orders', function() { //nested route
    this.route('order', { path: '/:order_id' });
  });
  this.route('customers');
  this.route('products');
});

export default Router;
