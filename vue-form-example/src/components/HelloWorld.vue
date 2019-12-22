<template>
  <div class="hello">
    <h3>{{msg}}</h3>
    <tr>
      <td>
        <label>bound text input</label>
      </td>
      <td>
        <input type="text" v-model="exampleBinding.data" />
      </td>
      <td>
        <button v-on:click="submitted">Submit</button>
      </td>
    </tr>
    <br />
    <br />
    <tr>
      <td>
        <label>Submit data: {{ dataSubmitObject }}</label>
      </td>
    </tr>
  </div>
</template>

<script>
// import axios from "axios";

export default {
  name: "HelloWorld",
  data () {
    return {
      exampleBinding: {
        data: ""
      },
      dataSubmitObject: {
        data: ""

      }
    }
  },
  methods : {
    submitted() {
      let json = JSON.stringify(this.exampleBinding);
      this.dataSubmitObject = json;
      // axios.post("<URL>", this.dataSubmit);
    }
  },
  props: {
    msg: String
  }
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h3 {
  margin: 40px 0 0;
}
tr {
  list-style-type: none;
  padding: 0;
}
td {
  display: inline-block;
  margin: 0 10px;
}
</style>
