<template>
  <nav class="demo">
      <a href="#" class="brand">
        <span>Achados e Perdidos</span>
      </a>

      <!-- responsive-->
      <input id="bmenub" type="checkbox" class="show">
      <label for="bmenub" class="burger pseudo button">menu</label>

      <div class="menu">
        <a href="#" class="pseudo button icon-picture">Home</a>
        <a href="#" class="pseudo button icon-picture">Log in</a>
      </div>
    </nav>
</template>

<script>
export default {
  name: 'menu'
}
</script>
