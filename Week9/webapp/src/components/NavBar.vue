<template>
  <div class="links">
    <div v-if="!$auth.loading">
      <span v-if="$auth.isAuthenticated" v-on:click="goToHome">Home Page</span>
      <span v-if="$auth.isAuthenticated" v-on:click="goToExternalApi">External Api</span>
      <span v-if="$auth.isAuthenticated" v-on:click="goToStudents">Students Page</span>
      <span v-if="$auth.isAuthenticated" v-on:click="goToInstructors">Instructors Page</span>
      <!-- show login when not authenticated -->
      <button v-if="!$auth.isAuthenticated" @click="login">Log in</button>
      <!-- show logout when authenticated -->
      <button v-if="$auth.isAuthenticated" @click="logout">Log out</button>
    </div>
  </div>
</template>

<script>
export default {
  name: "NavBar",
  methods: {
    goToHome: function() {
      this.$router.push({ path: "Home" });
    },
    goToStudents: function() {
      this.$router.push({ path: "Students" });
    },
    goToInstructors: function() {
      this.$router.push({ path: "Instructors" });
    },
    goToExternalApi: function() {
      this.$router.push({ path: "ExternalApi" });
    },
    login() {
      this.$auth.loginWithRedirect();
    },
    // Log the user out
    logout() {
      this.$auth.logout({
        returnTo: window.location.origin
      });
    }
  }
};
</script>

<style scoped>
span {
  font-family: monospace;
  font-weight: bold;
  font-size: 14pt;
  cursor: pointer;
  padding-right: 20px;
  background-color: white;
  text-align: center;
}
.links {
  background-color: lightgray;
  margin-top: 20px;
  padding: 10px;
}
</style>