import { CandidateTestTemplatePage } from './app.po';

describe('CandidateTest App', function() {
  let page: CandidateTestTemplatePage;

  beforeEach(() => {
    page = new CandidateTestTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
