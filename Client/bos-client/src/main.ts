import { createApp } from 'vue'
import App from './App.vue'
import router from './router'


import PrimeVue from 'primevue/config'
import Dialog from 'primevue/dialog'
import Menu from 'primevue/menu'
import StyleClass from 'primevue/styleclass'
import Tooltip from 'primevue/tooltip'
import Ripple from 'primevue/ripple'
import DataTable from 'primevue/datatable'
import Column from 'primevue/column'
import Button from 'primevue/button'
import InputText from 'primevue/inputtext'
import ToastService from 'primevue/toastservice'
import Toast from 'primevue/toast'
import Toolbar from 'primevue/toolbar'
import Dropdown from 'primevue/dropdown'
import MultiSelect from 'primevue/multiselect';
import Card from 'primevue/card';
import MegaMenu from 'primevue/megamenu'
import Menubar from 'primevue/menubar'
import TabMenu from 'primevue/tabmenu'
import TabView from 'primevue/tabview'
import TabPanel from 'primevue/tabpanel'
import Textarea from 'primevue/textarea'
import InputNumber from 'primevue/inputnumber'
import FileUpload from 'primevue/fileupload'
import Calendar from 'primevue/calendar'
import InputMask from 'primevue/inputmask';
import InputSwitch from 'primevue/inputswitch';


// import 'primevue/resources/themes/lara-light-indigo/theme.css'
// import 'primevue/resources/primevue.min.css'
// import 'primeicons/primeicons.css'
// import 'primeicons/primeicons.css'


createApp(App).use(router)
    // .use(PrimeVue, {
    //   ripple: true,
    // })
    // .use(ToastService)
    // .directive('ripple', Ripple)
    // .directive('tooltip', Tooltip)
    // .directive('styleclass', StyleClass)
    // .component('Dialog', Dialog)
    // .component('Menu', Menu)
    // .component('InputSwitch',InputSwitch)
    // .component('DataTable', DataTable)
    // .component('Column', Column)
    // .component('Button', Button)
    // .component('InputText', InputText)
    // .component('Dropdown',Dropdown)
    // .component('Toast', Toast)
    // .component('Toolbar', Toolbar)
    // .component('MultiSelect', MultiSelect)
    // .component('TabMenu', TabMenu)
    // .component('TabView', TabView)
    // .component('TabPanel', TabPanel)
    // .component('Textarea', Textarea)
    // .component('InputNumber', InputNumber)
    // .component('Calendar', Calendar)
    // .component('FileUpload', FileUpload)
    // .component('InputMask',InputMask)
    // .component('Menubar',Menubar)
    // .component('MegaMenu',MegaMenu)
    // .component('Card',Card)
    .mount('#app')
