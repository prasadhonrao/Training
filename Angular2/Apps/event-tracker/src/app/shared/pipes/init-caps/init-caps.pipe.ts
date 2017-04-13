import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'initCaps'
})
export class InitCapsPipe implements PipeTransform {

  transform(value: any, args?: any): any {
    return null;
  }

}
