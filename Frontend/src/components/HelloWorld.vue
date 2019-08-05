<template>
  <div>
    {{message}}
  </div>
</template>

<script lang="ts">
import { Component, Prop, Vue } from 'vue-property-decorator';
import { SimpleService } from '../services/SimpleService';

@Component
export default class HelloWorld extends Vue {
  public message: string = 'none';
  private simpleService!: SimpleService;

  private beforeCreate() {
    this.simpleService = new SimpleService();
  }

  private mounted() {
    this.simpleService.getValues().then((data) => {
      this.message = data.map((p) => p.name).join(', ');
    });
  }
}
</script>

<style scoped>
body {
  margin: 10px;
}
</style>
