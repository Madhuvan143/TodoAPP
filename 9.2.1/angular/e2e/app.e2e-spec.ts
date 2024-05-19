import { ToDoAppTemplatePage } from './app.po';

describe('ToDoApp App', function() {
  let page: ToDoAppTemplatePage;

  beforeEach(() => {
    page = new ToDoAppTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
