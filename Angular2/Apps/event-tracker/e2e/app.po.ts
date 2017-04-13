import { browser, element, by } from 'protractor';

export class EventTrackerPage {
  navigateTo() {
    return browser.get('/');
  }

  getParagraphText() {
    return element(by.css('et-root h1')).getText();
  }
}
