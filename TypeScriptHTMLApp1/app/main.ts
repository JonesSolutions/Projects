import { bootstrap } from '@angular/platform-browser-dynamic';
import { FirstComponent } from './first.component';

bootstrap(FirstComponent)
    .then(success => console.log(`bootstrap success`))
    .catch(error => console.log(error));