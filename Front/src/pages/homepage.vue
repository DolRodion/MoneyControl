
<template>
  <div>
    <p class="ml-5">Главная страница</p>
  </div>
</template>

<script setup lang="ts">
const name = ref('')
definePage({
  meta: {
    icon: 'mdi-home',
    title: 'Homepage',
    drawerIndex: 0,
  },
})
</script>

