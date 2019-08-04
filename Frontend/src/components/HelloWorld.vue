<template>
  <div>
    {{message}}
  </div>
</template>

<script lang="ts">
import { Component, Prop, Vue } from 'vue-property-decorator';

@Component
export default class HelloWorld extends Vue {
  public message : string = "none";
  
  public HelloWorld() {
  }
  
  public mounted() {
     
  }
}
</script>

<style scoped>
body {
  margin: 10px;
}
</style>
