import { API_URL_BASE } from '@/constants';
import { SimpleModel } from '@/models/SimpleModel';

export class SimpleService {
    private axios = require('axios');

    public async getValues(): Promise<SimpleModel[]> {
        return (await this.axios(API_URL_BASE + '/values')).data;
    }
}