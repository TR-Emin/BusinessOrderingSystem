import { Vue } from 'vue-class-component'
import { createApiForWebAPI } from "@/api"
import { BranchApi, CategoryApi, ProductApi } from '@/metadata/bos-admin-api'



export default class Admin extends Vue {

    branchApi: BranchApi = createApiForWebAPI(BranchApi)
    categoryApi: CategoryApi = createApiForWebAPI(CategoryApi)
    productApi: ProductApi = createApiForWebAPI(ProductApi)


    categoryList:any
    productList:any


    created(){
        this.listCategories();
        this.listProducts();
    }

    mounted(){

    }

    listCategories() {
        this.categoryApi.adminapiCategoryGetListAsyncGet().then(x => {
            this.categoryList = x.data.data;
            });
            // .catch(() => {
            //     this.$toast.add({ severity: 'error', summary: this.$t("error"), detail: this.$t("errorOnListingBuildings"), life: 3000 });
            // });
    }

    listProducts() {
        this.productApi.adminapiProductGetListAsyncGet().then(x => {
            this.categoryList = x.data.data;
            });
            // .catch(() => {
            //     this.$toast.add({ severity: 'error', summary: this.$t("error"), detail: this.$t("errorOnListingBuildings"), life: 3000 });
            // });
    }

}