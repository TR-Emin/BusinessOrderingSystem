import { BaseAPI as BaseAPIWeb} from "./metadata/bos-admin-api/base"

export function createApiForWebAPI<T extends BaseAPIWeb>(ctor: { new (): T }) : T {
    const api = new ctor()
    api["basePath"] = process.env.ADMIN_API_URL
    return api
}
