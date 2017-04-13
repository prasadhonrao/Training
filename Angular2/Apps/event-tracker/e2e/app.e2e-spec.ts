import { EventTrackerPage } from './app.po';

describe('event-tracker App', () => {
  let page: EventTrackerPage;

  beforeEach(() => {
    page = new EventTrackerPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('et works!');
  });
});
