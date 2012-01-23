configs ={
  :git => {
    :user => "20120123orlando",
    :remotes => %w[anortham bobbybristol],
    :repo => 'prep' 
  }
}
configatron.configure_from_hash(configs)
