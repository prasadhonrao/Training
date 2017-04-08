import { TestBed, inject } from '@angular/core/testing';

import { SpeakerService } from './speaker.service';

describe('SpeakerService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [SpeakerService]
    });
  });

  it('should ...', inject([SpeakerService], (service: SpeakerService) => {
    expect(service).toBeTruthy();
  }));
});
