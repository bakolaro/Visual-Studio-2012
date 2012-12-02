  


<!DOCTYPE html>
<html>
  <head prefix="og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# githubog: http://ogp.me/ns/fb/githubog#">
    <meta charset='utf-8'>
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <title>html5shiv/src/html5shiv.js at master · aFarkas/html5shiv · GitHub</title>
    <link rel="search" type="application/opensearchdescription+xml" href="/opensearch.xml" title="GitHub" />
    <link rel="fluid-icon" href="https://github.com/fluidicon.png" title="GitHub" />
    <link rel="apple-touch-icon-precomposed" sizes="57x57" href="apple-touch-icon-114.png" />
    <link rel="apple-touch-icon-precomposed" sizes="114x114" href="apple-touch-icon-114.png" />
    <link rel="apple-touch-icon-precomposed" sizes="72x72" href="apple-touch-icon-144.png" />
    <link rel="apple-touch-icon-precomposed" sizes="144x144" href="apple-touch-icon-144.png" />
    <meta name="msapplication-TileImage" content="/windows-tile.png">
    <meta name="msapplication-TileColor" content="#ffffff">

    
    
    <link rel="icon" type="image/x-icon" href="/favicon.ico" />

    <meta content="authenticity_token" name="csrf-param" />
<meta content="stlW0/ON68TZBi9c3DYLbxz2xILkHzk0If9t4dmTRrs=" name="csrf-token" />

    <link href="https://a248.e.akamai.net/assets.github.com/assets/github-18bd3584f9db1b540fe954d831904cc3700bd65a.css" media="screen" rel="stylesheet" type="text/css" />
    <link href="https://a248.e.akamai.net/assets.github.com/assets/github2-02d80c02085e3a06f7086f74680df1c868bdccdc.css" media="screen" rel="stylesheet" type="text/css" />
    


    <script src="https://a248.e.akamai.net/assets.github.com/assets/frameworks-57542e0cba19d068168099f287c117efa142863c.js" type="text/javascript"></script>
    <script src="https://a248.e.akamai.net/assets.github.com/assets/github-161b84440becbb32dcf40a22eb28100c739ef03c.js" type="text/javascript"></script>
    

      <link rel='permalink' href='/aFarkas/html5shiv/blob/4525162dd10e6fff7b83d06b28b562586e9fb058/src/html5shiv.js'>
    <meta property="og:title" content="html5shiv"/>
    <meta property="og:type" content="githubog:gitrepository"/>
    <meta property="og:url" content="https://github.com/aFarkas/html5shiv"/>
    <meta property="og:image" content="https://secure.gravatar.com/avatar/5c4f4e081b98517cf7c5b21f47d9fe33?s=420&amp;d=https://a248.e.akamai.net/assets.github.com%2Fimages%2Fgravatars%2Fgravatar-user-420.png"/>
    <meta property="og:site_name" content="GitHub"/>
    <meta property="og:description" content="html5shiv - This script is the defacto way to enable use of HTML5 sectioning elements in legacy Internet Explorer."/>

    <meta name="description" content="html5shiv - This script is the defacto way to enable use of HTML5 sectioning elements in legacy Internet Explorer." />

  <link href="https://github.com/aFarkas/html5shiv/commits/master.atom" rel="alternate" title="Recent Commits to html5shiv:master" type="application/atom+xml" />

  </head>


  <body class="logged_out page-blob windows vis-public env-production ">
    <div id="wrapper">

      

      

      


        <div class="header header-logged-out">
          <div class="container clearfix">

            <a class="header-logo-wordmark" href="https://github.com/">
              <img alt="GitHub" class="github-logo-4x" height="30" src="https://a248.e.akamai.net/assets.github.com/images/modules/header/logov7@4x.png?1340659511" />
              <img alt="GitHub" class="github-logo-4x-hover" height="30" src="https://a248.e.akamai.net/assets.github.com/images/modules/header/logov7@4x-hover.png?1340659511" />
            </a>

              
<ul class="top-nav">
    <li class="explore"><a href="https://github.com/explore">Explore GitHub</a></li>
  <li class="search"><a href="https://github.com/search">Search</a></li>
  <li class="features"><a href="https://github.com/features">Features</a></li>
    <li class="blog"><a href="https://github.com/blog">Blog</a></li>
</ul>


            <div class="header-actions">
                <a class="button primary classy" href="https://github.com/signup">Sign up for free</a>
              <a class="button classy" href="https://github.com/login?return_to=%2FaFarkas%2Fhtml5shiv%2Fblob%2Fmaster%2Fsrc%2Fhtml5shiv.js">Sign in</a>
            </div>

          </div>
        </div>


      

      


            <div class="site hfeed" itemscope itemtype="http://schema.org/WebPage">
      <div class="hentry">
        
        <div class="pagehead repohead instapaper_ignore readability-menu">
          <div class="container">
            <div class="title-actions-bar">
              


                  <ul class="pagehead-actions">


          <li>
            <span class="star-button"><a href="/login?return_to=%2FaFarkas%2Fhtml5shiv" class="minibutton js-toggler-target entice tooltipped leftwards" title="You must be signed in to use this feature" rel="nofollow"><span class="mini-icon mini-icon-star"></span>Star</a><a class="social-count js-social-count" href="/aFarkas/html5shiv/stargazers">1,644</a></span>
          </li>
          <li>
            <a href="/login?return_to=%2FaFarkas%2Fhtml5shiv" class="minibutton js-toggler-target fork-button entice tooltipped leftwards"  title="You must be signed in to fork a repository" rel="nofollow"><span class="mini-icon mini-icon-fork"></span>Fork</a><a href="/aFarkas/html5shiv/network" class="social-count">222</a>
          </li>
    </ul>

              <h1 itemscope itemtype="http://data-vocabulary.org/Breadcrumb" class="entry-title public">
                <span class="repo-label"><span>public</span></span>
                <span class="mega-icon mega-icon-public-repo"></span>
                <span class="author vcard">
                  <a href="/aFarkas" class="url fn" itemprop="url" rel="author">
                  <span itemprop="title">aFarkas</span>
                  </a></span> /
                <strong><a href="/aFarkas/html5shiv" class="js-current-repository">html5shiv</a></strong>
              </h1>
            </div>

            

  <ul class="tabs">
    <li><a href="/aFarkas/html5shiv" class="selected" highlight="repo_sourcerepo_downloadsrepo_commitsrepo_tagsrepo_branches">Code</a></li>
    <li><a href="/aFarkas/html5shiv/network" highlight="repo_network">Network</a></li>
    <li><a href="/aFarkas/html5shiv/pulls" highlight="repo_pulls">Pull Requests <span class='counter'>1</span></a></li>

      <li><a href="/aFarkas/html5shiv/issues" highlight="repo_issues">Issues <span class='counter'>11</span></a></li>

      <li><a href="/aFarkas/html5shiv/wiki" highlight="repo_wiki">Wiki</a></li>


    <li><a href="/aFarkas/html5shiv/graphs" highlight="repo_graphsrepo_contributors">Graphs</a></li>


  </ul>
  
<div class="tabnav">

  <span class="tabnav-right">
    <ul class="tabnav-tabs">
      <li><a href="/aFarkas/html5shiv/tags" class="tabnav-tab" highlight="repo_tags">Tags <span class="counter ">9</span></a></li>
      <li><a href="/aFarkas/html5shiv/downloads" class="tabnav-tab" highlight="repo_downloads">Downloads <span class="counter blank">0</span></a></li>
    </ul>
    
  </span>

  <div class="tabnav-widget scope">


    <div class="context-menu-container js-menu-container js-context-menu">
      <a href="#"
         class="minibutton bigger switcher js-menu-target js-commitish-button btn-branch repo-tree"
         data-hotkey="w"
         data-ref="master">
         <span><em class="mini-icon mini-icon-branch"></em><i>branch:</i> master</span>
      </a>

      <div class="context-pane commitish-context js-menu-content">
        <a href="javascript:;" class="close js-menu-close"><span class="mini-icon mini-icon-remove-close"></span></a>
        <div class="context-title">Switch branches/tags</div>
        <div class="context-body pane-selector commitish-selector js-navigation-container">
          <div class="filterbar">
            <input type="text" id="context-commitish-filter-field" class="js-navigation-enable js-filterable-field" placeholder="Filter branches/tags">
            <ul class="tabs">
              <li><a href="#" data-filter="branches" class="selected">Branches</a></li>
                <li><a href="#" data-filter="tags">Tags</a></li>
            </ul>
          </div>

          <div class="js-filter-tab js-filter-branches">
            <div data-filterable-for="context-commitish-filter-field" data-filterable-type=substring>
                <div class="commitish-item branch-commitish selector-item js-navigation-item js-navigation-target ">
                  <span class="mini-icon mini-icon-confirm"></span>
                  <h4>
                      <a href="/aFarkas/html5shiv/blob/defineProperty/src/html5shiv.js" class="js-navigation-open" data-name="defineProperty" rel="nofollow">defineProperty</a>
                  </h4>
                </div>
                <div class="commitish-item branch-commitish selector-item js-navigation-item js-navigation-target ">
                  <span class="mini-icon mini-icon-confirm"></span>
                  <h4>
                      <a href="/aFarkas/html5shiv/blob/gh-pages/src/html5shiv.js" class="js-navigation-open" data-name="gh-pages" rel="nofollow">gh-pages</a>
                  </h4>
                </div>
                <div class="commitish-item branch-commitish selector-item js-navigation-item js-navigation-target ">
                  <span class="mini-icon mini-icon-confirm"></span>
                  <h4>
                      <a href="/aFarkas/html5shiv/blob/iepp-htc/src/html5shiv.js" class="js-navigation-open" data-name="iepp-htc" rel="nofollow">iepp-htc</a>
                  </h4>
                </div>
                <div class="commitish-item branch-commitish selector-item js-navigation-item js-navigation-target ">
                  <span class="mini-icon mini-icon-confirm"></span>
                  <h4>
                      <a href="/aFarkas/html5shiv/blob/innershiv/src/html5shiv.js" class="js-navigation-open" data-name="innershiv" rel="nofollow">innershiv</a>
                  </h4>
                </div>
                <div class="commitish-item branch-commitish selector-item js-navigation-item js-navigation-target selected">
                  <span class="mini-icon mini-icon-confirm"></span>
                  <h4>
                      <a href="/aFarkas/html5shiv/blob/master/src/html5shiv.js" class="js-navigation-open" data-name="master" rel="nofollow">master</a>
                  </h4>
                </div>
            </div>
            <div class="no-results">Nothing to show</div>
          </div>

            <div class="js-filter-tab js-filter-tags " style="display:none">
              <div data-filterable-for="context-commitish-filter-field" data-filterable-type=substring>
                  <div class="commitish-item tag-commitish selector-item js-navigation-item js-navigation-target ">
                    <span class="mini-icon mini-icon-confirm"></span>
                    <h4>
                        <a href="/aFarkas/html5shiv/blob/3.6.1/src/html5shiv.js" class="js-navigation-open" data-name="3.6.1" rel="nofollow">3.6.1</a>
                    </h4>
                  </div>
                  <div class="commitish-item tag-commitish selector-item js-navigation-item js-navigation-target ">
                    <span class="mini-icon mini-icon-confirm"></span>
                    <h4>
                        <a href="/aFarkas/html5shiv/blob/3.6/src/html5shiv.js" class="js-navigation-open" data-name="3.6" rel="nofollow">3.6</a>
                    </h4>
                  </div>
                  <div class="commitish-item tag-commitish selector-item js-navigation-item js-navigation-target ">
                    <span class="mini-icon mini-icon-confirm"></span>
                    <h4>
                        <a href="/aFarkas/html5shiv/blob/3.5/src/html5shiv.js" class="js-navigation-open" data-name="3.5" rel="nofollow">3.5</a>
                    </h4>
                  </div>
                  <div class="commitish-item tag-commitish selector-item js-navigation-item js-navigation-target ">
                    <span class="mini-icon mini-icon-confirm"></span>
                    <h4>
                        <a href="/aFarkas/html5shiv/blob/3.4/src/html5shiv.js" class="js-navigation-open" data-name="3.4" rel="nofollow">3.4</a>
                    </h4>
                  </div>
                  <div class="commitish-item tag-commitish selector-item js-navigation-item js-navigation-target ">
                    <span class="mini-icon mini-icon-confirm"></span>
                    <h4>
                        <a href="/aFarkas/html5shiv/blob/3.3/src/html5shiv.js" class="js-navigation-open" data-name="3.3" rel="nofollow">3.3</a>
                    </h4>
                  </div>
                  <div class="commitish-item tag-commitish selector-item js-navigation-item js-navigation-target ">
                    <span class="mini-icon mini-icon-confirm"></span>
                    <h4>
                        <a href="/aFarkas/html5shiv/blob/3.2/src/html5shiv.js" class="js-navigation-open" data-name="3.2" rel="nofollow">3.2</a>
                    </h4>
                  </div>
                  <div class="commitish-item tag-commitish selector-item js-navigation-item js-navigation-target ">
                    <span class="mini-icon mini-icon-confirm"></span>
                    <h4>
                        <a href="/aFarkas/html5shiv/blob/3.1/src/html5shiv.js" class="js-navigation-open" data-name="3.1" rel="nofollow">3.1</a>
                    </h4>
                  </div>
                  <div class="commitish-item tag-commitish selector-item js-navigation-item js-navigation-target ">
                    <span class="mini-icon mini-icon-confirm"></span>
                    <h4>
                        <a href="/aFarkas/html5shiv/blob/2.2/src/html5shiv.js" class="js-navigation-open" data-name="2.2" rel="nofollow">2.2</a>
                    </h4>
                  </div>
                  <div class="commitish-item tag-commitish selector-item js-navigation-item js-navigation-target ">
                    <span class="mini-icon mini-icon-confirm"></span>
                    <h4>
                        <a href="/aFarkas/html5shiv/blob/2.1/src/html5shiv.js" class="js-navigation-open" data-name="2.1" rel="nofollow">2.1</a>
                    </h4>
                  </div>
              </div>
              <div class="no-results">Nothing to show</div>
            </div>
        </div>
      </div><!-- /.commitish-context-context -->
    </div>
  </div> <!-- /.scope -->

  <ul class="tabnav-tabs">
    <li><a href="/aFarkas/html5shiv" class="selected tabnav-tab" highlight="repo_source">Files</a></li>
    <li><a href="/aFarkas/html5shiv/commits/master" class="tabnav-tab" highlight="repo_commits">Commits</a></li>
    <li><a href="/aFarkas/html5shiv/branches" class="tabnav-tab" highlight="repo_branches" rel="nofollow">Branches <span class="counter ">5</span></a></li>
  </ul>

</div>

  
  
  


            
          </div>
        </div><!-- /.repohead -->

        <div id="js-repo-pjax-container" class="container context-loader-container" data-pjax-container>
          


<!-- blob contrib key: blob_contributors:v21:6ec500bc625c8ecedf208f6214808e03 -->
<!-- blob contrib frag key: views10/v8/blob_contributors:v21:6ec500bc625c8ecedf208f6214808e03 -->

<div id="slider">


    <p title="This is a placeholder element" class="js-history-link-replace hidden"></p>
    <div class="breadcrumb" data-path="src/html5shiv.js/">
      <span class='bold'><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/aFarkas/html5shiv" class="js-slider-breadcrumb" itemscope="url"><span itemprop="title">html5shiv</span></a></span></span> / <span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/aFarkas/html5shiv/tree/master/src" class="js-slider-breadcrumb" itemscope="url"><span itemprop="title">src</span></a></span> / <strong class="final-path">html5shiv.js</strong> <span class="js-clippy mini-icon mini-icon-clippy " data-clipboard-text="src/html5shiv.js" data-copied-hint="copied!" data-copy-hint="copy to clipboard"></span>
    </div>

    <a href="/aFarkas/html5shiv/find/master" class="js-slide-to" data-hotkey="t" style="display:none">Show File Finder</a>

      
  <div class="commit file-history-tease" data-path="src/html5shiv.js/">
    <img class="main-avatar" height="24" src="https://secure.gravatar.com/avatar/5c4f4e081b98517cf7c5b21f47d9fe33?s=140&amp;d=https://a248.e.akamai.net/assets.github.com%2Fimages%2Fgravatars%2Fgravatar-user-420.png" width="24" />
    <span class="author"><a href="/aFarkas">aFarkas</a></span>
    <time class="js-relative-date" datetime="2012-09-02T10:55:08-07:00" title="2012-09-02 10:55:08">September 02, 2012</time>
    <div class="commit-title">
        <a href="/aFarkas/html5shiv/commit/4525162dd10e6fff7b83d06b28b562586e9fb058" class="message">use </a><a class="user-mention" href="https://github.com/preserve">@preserve</a><a href="/aFarkas/html5shiv/commit/4525162dd10e6fff7b83d06b28b562586e9fb058" class="message"> version and license comments and expose version propert…</a>
    </div>

    <div class="participation">
      <p class="quickstat"><a href="#blob_contributors_box" rel="facebox"><strong>4</strong> contributors</a></p>
          <a class="avatar tooltipped downwards" title="aFarkas" href="/aFarkas/html5shiv/commits/master/src/html5shiv.js?author=aFarkas"><img height="20" src="https://secure.gravatar.com/avatar/5c4f4e081b98517cf7c5b21f47d9fe33?s=140&amp;d=https://a248.e.akamai.net/assets.github.com%2Fimages%2Fgravatars%2Fgravatar-user-420.png" width="20" /></a>
    <a class="avatar tooltipped downwards" title="jonathantneal" href="/aFarkas/html5shiv/commits/master/src/html5shiv.js?author=jonathantneal"><img height="20" src="https://secure.gravatar.com/avatar/2889096995a38fa697ab83d8b59a5637?s=140&amp;d=https://a248.e.akamai.net/assets.github.com%2Fimages%2Fgravatars%2Fgravatar-user-420.png" width="20" /></a>
    <a class="avatar tooltipped downwards" title="jdalton" href="/aFarkas/html5shiv/commits/master/src/html5shiv.js?author=jdalton"><img height="20" src="https://secure.gravatar.com/avatar/299a3d891ff1920b69c364d061007043?s=140&amp;d=https://a248.e.akamai.net/assets.github.com%2Fimages%2Fgravatars%2Fgravatar-user-420.png" width="20" /></a>
    <a class="avatar tooltipped downwards" title="paulirish" href="/aFarkas/html5shiv/commits/master/src/html5shiv.js?author=paulirish"><img height="20" src="https://secure.gravatar.com/avatar/ffe68d6f71b225f7661d33f2a8908281?s=140&amp;d=https://a248.e.akamai.net/assets.github.com%2Fimages%2Fgravatars%2Fgravatar-user-420.png" width="20" /></a>


    </div>
    <div id="blob_contributors_box" style="display:none">
      <h2>Users on GitHub who have contributed to this file</h2>
      <ul class="facebox-user-list">
        <li>
          <img height="24" src="https://secure.gravatar.com/avatar/5c4f4e081b98517cf7c5b21f47d9fe33?s=140&amp;d=https://a248.e.akamai.net/assets.github.com%2Fimages%2Fgravatars%2Fgravatar-user-420.png" width="24" />
          <a href="/aFarkas">aFarkas</a>
        </li>
        <li>
          <img height="24" src="https://secure.gravatar.com/avatar/2889096995a38fa697ab83d8b59a5637?s=140&amp;d=https://a248.e.akamai.net/assets.github.com%2Fimages%2Fgravatars%2Fgravatar-user-420.png" width="24" />
          <a href="/jonathantneal">jonathantneal</a>
        </li>
        <li>
          <img height="24" src="https://secure.gravatar.com/avatar/299a3d891ff1920b69c364d061007043?s=140&amp;d=https://a248.e.akamai.net/assets.github.com%2Fimages%2Fgravatars%2Fgravatar-user-420.png" width="24" />
          <a href="/jdalton">jdalton</a>
        </li>
        <li>
          <img height="24" src="https://secure.gravatar.com/avatar/ffe68d6f71b225f7661d33f2a8908281?s=140&amp;d=https://a248.e.akamai.net/assets.github.com%2Fimages%2Fgravatars%2Fgravatar-user-420.png" width="24" />
          <a href="/paulirish">paulirish</a>
        </li>
      </ul>
    </div>
  </div>


    <div class="frames">
      <div class="frame frame-center" data-path="src/html5shiv.js/" data-permalink-url="/aFarkas/html5shiv/blob/4525162dd10e6fff7b83d06b28b562586e9fb058/src/html5shiv.js" data-title="html5shiv/src/html5shiv.js at master · aFarkas/html5shiv · GitHub" data-type="blob">

        <div id="files" class="bubble">
          <div class="file">
            <div class="meta">
              <div class="info">
                <span class="icon"><b class="mini-icon mini-icon-text-file"></b></span>
                <span class="mode" title="File Mode">file</span>
                  <span>298 lines (256 sloc)</span>
                <span>9.342 kb</span>
              </div>
              <ul class="button-group actions">
                  <li>
                      <a class="grouped-button minibutton bigger lighter js-entice" href=""
                         data-entice="You must be signed in and on a branch to make or propose changes">Edit</a>
                  </li>
                <li><a href="/aFarkas/html5shiv/raw/master/src/html5shiv.js" class="minibutton grouped-button bigger lighter" id="raw-url">Raw</a></li>
                  <li><a href="/aFarkas/html5shiv/blame/master/src/html5shiv.js" class="minibutton grouped-button bigger lighter">Blame</a></li>
                <li><a href="/aFarkas/html5shiv/commits/master/src/html5shiv.js" class="minibutton grouped-button bigger lighter" rel="nofollow">History</a></li>
              </ul>
            </div>
                <div class="data type-javascript">
      <table cellpadding="0" cellspacing="0" class="lines">
        <tr>
          <td>
            <pre class="line_numbers"><span id="L1" rel="#L1">1</span>
<span id="L2" rel="#L2">2</span>
<span id="L3" rel="#L3">3</span>
<span id="L4" rel="#L4">4</span>
<span id="L5" rel="#L5">5</span>
<span id="L6" rel="#L6">6</span>
<span id="L7" rel="#L7">7</span>
<span id="L8" rel="#L8">8</span>
<span id="L9" rel="#L9">9</span>
<span id="L10" rel="#L10">10</span>
<span id="L11" rel="#L11">11</span>
<span id="L12" rel="#L12">12</span>
<span id="L13" rel="#L13">13</span>
<span id="L14" rel="#L14">14</span>
<span id="L15" rel="#L15">15</span>
<span id="L16" rel="#L16">16</span>
<span id="L17" rel="#L17">17</span>
<span id="L18" rel="#L18">18</span>
<span id="L19" rel="#L19">19</span>
<span id="L20" rel="#L20">20</span>
<span id="L21" rel="#L21">21</span>
<span id="L22" rel="#L22">22</span>
<span id="L23" rel="#L23">23</span>
<span id="L24" rel="#L24">24</span>
<span id="L25" rel="#L25">25</span>
<span id="L26" rel="#L26">26</span>
<span id="L27" rel="#L27">27</span>
<span id="L28" rel="#L28">28</span>
<span id="L29" rel="#L29">29</span>
<span id="L30" rel="#L30">30</span>
<span id="L31" rel="#L31">31</span>
<span id="L32" rel="#L32">32</span>
<span id="L33" rel="#L33">33</span>
<span id="L34" rel="#L34">34</span>
<span id="L35" rel="#L35">35</span>
<span id="L36" rel="#L36">36</span>
<span id="L37" rel="#L37">37</span>
<span id="L38" rel="#L38">38</span>
<span id="L39" rel="#L39">39</span>
<span id="L40" rel="#L40">40</span>
<span id="L41" rel="#L41">41</span>
<span id="L42" rel="#L42">42</span>
<span id="L43" rel="#L43">43</span>
<span id="L44" rel="#L44">44</span>
<span id="L45" rel="#L45">45</span>
<span id="L46" rel="#L46">46</span>
<span id="L47" rel="#L47">47</span>
<span id="L48" rel="#L48">48</span>
<span id="L49" rel="#L49">49</span>
<span id="L50" rel="#L50">50</span>
<span id="L51" rel="#L51">51</span>
<span id="L52" rel="#L52">52</span>
<span id="L53" rel="#L53">53</span>
<span id="L54" rel="#L54">54</span>
<span id="L55" rel="#L55">55</span>
<span id="L56" rel="#L56">56</span>
<span id="L57" rel="#L57">57</span>
<span id="L58" rel="#L58">58</span>
<span id="L59" rel="#L59">59</span>
<span id="L60" rel="#L60">60</span>
<span id="L61" rel="#L61">61</span>
<span id="L62" rel="#L62">62</span>
<span id="L63" rel="#L63">63</span>
<span id="L64" rel="#L64">64</span>
<span id="L65" rel="#L65">65</span>
<span id="L66" rel="#L66">66</span>
<span id="L67" rel="#L67">67</span>
<span id="L68" rel="#L68">68</span>
<span id="L69" rel="#L69">69</span>
<span id="L70" rel="#L70">70</span>
<span id="L71" rel="#L71">71</span>
<span id="L72" rel="#L72">72</span>
<span id="L73" rel="#L73">73</span>
<span id="L74" rel="#L74">74</span>
<span id="L75" rel="#L75">75</span>
<span id="L76" rel="#L76">76</span>
<span id="L77" rel="#L77">77</span>
<span id="L78" rel="#L78">78</span>
<span id="L79" rel="#L79">79</span>
<span id="L80" rel="#L80">80</span>
<span id="L81" rel="#L81">81</span>
<span id="L82" rel="#L82">82</span>
<span id="L83" rel="#L83">83</span>
<span id="L84" rel="#L84">84</span>
<span id="L85" rel="#L85">85</span>
<span id="L86" rel="#L86">86</span>
<span id="L87" rel="#L87">87</span>
<span id="L88" rel="#L88">88</span>
<span id="L89" rel="#L89">89</span>
<span id="L90" rel="#L90">90</span>
<span id="L91" rel="#L91">91</span>
<span id="L92" rel="#L92">92</span>
<span id="L93" rel="#L93">93</span>
<span id="L94" rel="#L94">94</span>
<span id="L95" rel="#L95">95</span>
<span id="L96" rel="#L96">96</span>
<span id="L97" rel="#L97">97</span>
<span id="L98" rel="#L98">98</span>
<span id="L99" rel="#L99">99</span>
<span id="L100" rel="#L100">100</span>
<span id="L101" rel="#L101">101</span>
<span id="L102" rel="#L102">102</span>
<span id="L103" rel="#L103">103</span>
<span id="L104" rel="#L104">104</span>
<span id="L105" rel="#L105">105</span>
<span id="L106" rel="#L106">106</span>
<span id="L107" rel="#L107">107</span>
<span id="L108" rel="#L108">108</span>
<span id="L109" rel="#L109">109</span>
<span id="L110" rel="#L110">110</span>
<span id="L111" rel="#L111">111</span>
<span id="L112" rel="#L112">112</span>
<span id="L113" rel="#L113">113</span>
<span id="L114" rel="#L114">114</span>
<span id="L115" rel="#L115">115</span>
<span id="L116" rel="#L116">116</span>
<span id="L117" rel="#L117">117</span>
<span id="L118" rel="#L118">118</span>
<span id="L119" rel="#L119">119</span>
<span id="L120" rel="#L120">120</span>
<span id="L121" rel="#L121">121</span>
<span id="L122" rel="#L122">122</span>
<span id="L123" rel="#L123">123</span>
<span id="L124" rel="#L124">124</span>
<span id="L125" rel="#L125">125</span>
<span id="L126" rel="#L126">126</span>
<span id="L127" rel="#L127">127</span>
<span id="L128" rel="#L128">128</span>
<span id="L129" rel="#L129">129</span>
<span id="L130" rel="#L130">130</span>
<span id="L131" rel="#L131">131</span>
<span id="L132" rel="#L132">132</span>
<span id="L133" rel="#L133">133</span>
<span id="L134" rel="#L134">134</span>
<span id="L135" rel="#L135">135</span>
<span id="L136" rel="#L136">136</span>
<span id="L137" rel="#L137">137</span>
<span id="L138" rel="#L138">138</span>
<span id="L139" rel="#L139">139</span>
<span id="L140" rel="#L140">140</span>
<span id="L141" rel="#L141">141</span>
<span id="L142" rel="#L142">142</span>
<span id="L143" rel="#L143">143</span>
<span id="L144" rel="#L144">144</span>
<span id="L145" rel="#L145">145</span>
<span id="L146" rel="#L146">146</span>
<span id="L147" rel="#L147">147</span>
<span id="L148" rel="#L148">148</span>
<span id="L149" rel="#L149">149</span>
<span id="L150" rel="#L150">150</span>
<span id="L151" rel="#L151">151</span>
<span id="L152" rel="#L152">152</span>
<span id="L153" rel="#L153">153</span>
<span id="L154" rel="#L154">154</span>
<span id="L155" rel="#L155">155</span>
<span id="L156" rel="#L156">156</span>
<span id="L157" rel="#L157">157</span>
<span id="L158" rel="#L158">158</span>
<span id="L159" rel="#L159">159</span>
<span id="L160" rel="#L160">160</span>
<span id="L161" rel="#L161">161</span>
<span id="L162" rel="#L162">162</span>
<span id="L163" rel="#L163">163</span>
<span id="L164" rel="#L164">164</span>
<span id="L165" rel="#L165">165</span>
<span id="L166" rel="#L166">166</span>
<span id="L167" rel="#L167">167</span>
<span id="L168" rel="#L168">168</span>
<span id="L169" rel="#L169">169</span>
<span id="L170" rel="#L170">170</span>
<span id="L171" rel="#L171">171</span>
<span id="L172" rel="#L172">172</span>
<span id="L173" rel="#L173">173</span>
<span id="L174" rel="#L174">174</span>
<span id="L175" rel="#L175">175</span>
<span id="L176" rel="#L176">176</span>
<span id="L177" rel="#L177">177</span>
<span id="L178" rel="#L178">178</span>
<span id="L179" rel="#L179">179</span>
<span id="L180" rel="#L180">180</span>
<span id="L181" rel="#L181">181</span>
<span id="L182" rel="#L182">182</span>
<span id="L183" rel="#L183">183</span>
<span id="L184" rel="#L184">184</span>
<span id="L185" rel="#L185">185</span>
<span id="L186" rel="#L186">186</span>
<span id="L187" rel="#L187">187</span>
<span id="L188" rel="#L188">188</span>
<span id="L189" rel="#L189">189</span>
<span id="L190" rel="#L190">190</span>
<span id="L191" rel="#L191">191</span>
<span id="L192" rel="#L192">192</span>
<span id="L193" rel="#L193">193</span>
<span id="L194" rel="#L194">194</span>
<span id="L195" rel="#L195">195</span>
<span id="L196" rel="#L196">196</span>
<span id="L197" rel="#L197">197</span>
<span id="L198" rel="#L198">198</span>
<span id="L199" rel="#L199">199</span>
<span id="L200" rel="#L200">200</span>
<span id="L201" rel="#L201">201</span>
<span id="L202" rel="#L202">202</span>
<span id="L203" rel="#L203">203</span>
<span id="L204" rel="#L204">204</span>
<span id="L205" rel="#L205">205</span>
<span id="L206" rel="#L206">206</span>
<span id="L207" rel="#L207">207</span>
<span id="L208" rel="#L208">208</span>
<span id="L209" rel="#L209">209</span>
<span id="L210" rel="#L210">210</span>
<span id="L211" rel="#L211">211</span>
<span id="L212" rel="#L212">212</span>
<span id="L213" rel="#L213">213</span>
<span id="L214" rel="#L214">214</span>
<span id="L215" rel="#L215">215</span>
<span id="L216" rel="#L216">216</span>
<span id="L217" rel="#L217">217</span>
<span id="L218" rel="#L218">218</span>
<span id="L219" rel="#L219">219</span>
<span id="L220" rel="#L220">220</span>
<span id="L221" rel="#L221">221</span>
<span id="L222" rel="#L222">222</span>
<span id="L223" rel="#L223">223</span>
<span id="L224" rel="#L224">224</span>
<span id="L225" rel="#L225">225</span>
<span id="L226" rel="#L226">226</span>
<span id="L227" rel="#L227">227</span>
<span id="L228" rel="#L228">228</span>
<span id="L229" rel="#L229">229</span>
<span id="L230" rel="#L230">230</span>
<span id="L231" rel="#L231">231</span>
<span id="L232" rel="#L232">232</span>
<span id="L233" rel="#L233">233</span>
<span id="L234" rel="#L234">234</span>
<span id="L235" rel="#L235">235</span>
<span id="L236" rel="#L236">236</span>
<span id="L237" rel="#L237">237</span>
<span id="L238" rel="#L238">238</span>
<span id="L239" rel="#L239">239</span>
<span id="L240" rel="#L240">240</span>
<span id="L241" rel="#L241">241</span>
<span id="L242" rel="#L242">242</span>
<span id="L243" rel="#L243">243</span>
<span id="L244" rel="#L244">244</span>
<span id="L245" rel="#L245">245</span>
<span id="L246" rel="#L246">246</span>
<span id="L247" rel="#L247">247</span>
<span id="L248" rel="#L248">248</span>
<span id="L249" rel="#L249">249</span>
<span id="L250" rel="#L250">250</span>
<span id="L251" rel="#L251">251</span>
<span id="L252" rel="#L252">252</span>
<span id="L253" rel="#L253">253</span>
<span id="L254" rel="#L254">254</span>
<span id="L255" rel="#L255">255</span>
<span id="L256" rel="#L256">256</span>
<span id="L257" rel="#L257">257</span>
<span id="L258" rel="#L258">258</span>
<span id="L259" rel="#L259">259</span>
<span id="L260" rel="#L260">260</span>
<span id="L261" rel="#L261">261</span>
<span id="L262" rel="#L262">262</span>
<span id="L263" rel="#L263">263</span>
<span id="L264" rel="#L264">264</span>
<span id="L265" rel="#L265">265</span>
<span id="L266" rel="#L266">266</span>
<span id="L267" rel="#L267">267</span>
<span id="L268" rel="#L268">268</span>
<span id="L269" rel="#L269">269</span>
<span id="L270" rel="#L270">270</span>
<span id="L271" rel="#L271">271</span>
<span id="L272" rel="#L272">272</span>
<span id="L273" rel="#L273">273</span>
<span id="L274" rel="#L274">274</span>
<span id="L275" rel="#L275">275</span>
<span id="L276" rel="#L276">276</span>
<span id="L277" rel="#L277">277</span>
<span id="L278" rel="#L278">278</span>
<span id="L279" rel="#L279">279</span>
<span id="L280" rel="#L280">280</span>
<span id="L281" rel="#L281">281</span>
<span id="L282" rel="#L282">282</span>
<span id="L283" rel="#L283">283</span>
<span id="L284" rel="#L284">284</span>
<span id="L285" rel="#L285">285</span>
<span id="L286" rel="#L286">286</span>
<span id="L287" rel="#L287">287</span>
<span id="L288" rel="#L288">288</span>
<span id="L289" rel="#L289">289</span>
<span id="L290" rel="#L290">290</span>
<span id="L291" rel="#L291">291</span>
<span id="L292" rel="#L292">292</span>
<span id="L293" rel="#L293">293</span>
<span id="L294" rel="#L294">294</span>
<span id="L295" rel="#L295">295</span>
<span id="L296" rel="#L296">296</span>
<span id="L297" rel="#L297">297</span>
<span id="L298" rel="#L298">298</span>
</pre>
          </td>
          <td width="100%">
                <div class="highlight"><pre><div class='line' id='LC1'><span class="cm">/**</span></div><div class='line' id='LC2'><span class="cm">* @preserve HTML5 Shiv v3.6.2pre | @afarkas @jdalton @jon_neal @rem | MIT/GPL2 Licensed</span></div><div class='line' id='LC3'><span class="cm">*/</span></div><div class='line' id='LC4'><span class="p">;(</span><span class="kd">function</span><span class="p">(</span><span class="nb">window</span><span class="p">,</span> <span class="nb">document</span><span class="p">)</span> <span class="p">{</span></div><div class='line' id='LC5'><span class="cm">/*jshint evil:true */</span></div><div class='line' id='LC6'>&nbsp;&nbsp;<span class="cm">/** version */</span></div><div class='line' id='LC7'>&nbsp;&nbsp;<span class="kd">var</span> <span class="nx">version</span> <span class="o">=</span> <span class="s1">&#39;3.6.2pre&#39;</span><span class="p">;</span></div><div class='line' id='LC8'><br/></div><div class='line' id='LC9'>&nbsp;&nbsp;<span class="cm">/** Preset options */</span></div><div class='line' id='LC10'>&nbsp;&nbsp;<span class="kd">var</span> <span class="nx">options</span> <span class="o">=</span> <span class="nb">window</span><span class="p">.</span><span class="nx">html5</span> <span class="o">||</span> <span class="p">{};</span></div><div class='line' id='LC11'><br/></div><div class='line' id='LC12'>&nbsp;&nbsp;<span class="cm">/** Used to skip problem elements */</span></div><div class='line' id='LC13'>&nbsp;&nbsp;<span class="kd">var</span> <span class="nx">reSkip</span> <span class="o">=</span> <span class="sr">/^&lt;|^(?:button|map|select|textarea|object|iframe|option|optgroup)$/i</span><span class="p">;</span></div><div class='line' id='LC14'><br/></div><div class='line' id='LC15'>&nbsp;&nbsp;<span class="cm">/** Not all elements can be cloned in IE **/</span></div><div class='line' id='LC16'>&nbsp;&nbsp;<span class="kd">var</span> <span class="nx">saveClones</span> <span class="o">=</span> <span class="sr">/^(?:a|b|code|div|fieldset|h1|h2|h3|h4|h5|h6|i|label|li|ol|p|q|span|strong|style|table|tbody|td|th|tr|ul)$/i</span><span class="p">;</span></div><div class='line' id='LC17'><br/></div><div class='line' id='LC18'>&nbsp;&nbsp;<span class="cm">/** Detect whether the browser supports default html5 styles */</span></div><div class='line' id='LC19'>&nbsp;&nbsp;<span class="kd">var</span> <span class="nx">supportsHtml5Styles</span><span class="p">;</span></div><div class='line' id='LC20'><br/></div><div class='line' id='LC21'>&nbsp;&nbsp;<span class="cm">/** Name of the expando, to work with multiple documents or to re-shiv one document */</span></div><div class='line' id='LC22'>&nbsp;&nbsp;<span class="kd">var</span> <span class="nx">expando</span> <span class="o">=</span> <span class="s1">&#39;_html5shiv&#39;</span><span class="p">;</span></div><div class='line' id='LC23'><br/></div><div class='line' id='LC24'>&nbsp;&nbsp;<span class="cm">/** The id for the the documents expando */</span></div><div class='line' id='LC25'>&nbsp;&nbsp;<span class="kd">var</span> <span class="nx">expanID</span> <span class="o">=</span> <span class="mi">0</span><span class="p">;</span></div><div class='line' id='LC26'><br/></div><div class='line' id='LC27'>&nbsp;&nbsp;<span class="cm">/** Cached data for each document */</span></div><div class='line' id='LC28'>&nbsp;&nbsp;<span class="kd">var</span> <span class="nx">expandoData</span> <span class="o">=</span> <span class="p">{};</span></div><div class='line' id='LC29'><br/></div><div class='line' id='LC30'>&nbsp;&nbsp;<span class="cm">/** Detect whether the browser supports unknown elements */</span></div><div class='line' id='LC31'>&nbsp;&nbsp;<span class="kd">var</span> <span class="nx">supportsUnknownElements</span><span class="p">;</span></div><div class='line' id='LC32'><br/></div><div class='line' id='LC33'>&nbsp;&nbsp;<span class="p">(</span><span class="kd">function</span><span class="p">()</span> <span class="p">{</span></div><div class='line' id='LC34'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="k">try</span> <span class="p">{</span></div><div class='line' id='LC35'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="kd">var</span> <span class="nx">a</span> <span class="o">=</span> <span class="nb">document</span><span class="p">.</span><span class="nx">createElement</span><span class="p">(</span><span class="s1">&#39;a&#39;</span><span class="p">);</span></div><div class='line' id='LC36'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">a</span><span class="p">.</span><span class="nx">innerHTML</span> <span class="o">=</span> <span class="s1">&#39;&lt;xyz&gt;&lt;/xyz&gt;&#39;</span><span class="p">;</span></div><div class='line' id='LC37'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="c1">//if the hidden property is implemented we can assume, that the browser supports basic HTML5 Styles</span></div><div class='line' id='LC38'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">supportsHtml5Styles</span> <span class="o">=</span> <span class="p">(</span><span class="s1">&#39;hidden&#39;</span> <span class="k">in</span> <span class="nx">a</span><span class="p">);</span></div><div class='line' id='LC39'><br/></div><div class='line' id='LC40'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">supportsUnknownElements</span> <span class="o">=</span> <span class="nx">a</span><span class="p">.</span><span class="nx">childNodes</span><span class="p">.</span><span class="nx">length</span> <span class="o">==</span> <span class="mi">1</span> <span class="o">||</span> <span class="p">(</span><span class="kd">function</span><span class="p">()</span> <span class="p">{</span></div><div class='line' id='LC41'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="c1">// assign a false positive if unable to shiv</span></div><div class='line' id='LC42'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="p">(</span><span class="nb">document</span><span class="p">.</span><span class="nx">createElement</span><span class="p">)(</span><span class="s1">&#39;a&#39;</span><span class="p">);</span></div><div class='line' id='LC43'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="kd">var</span> <span class="nx">frag</span> <span class="o">=</span> <span class="nb">document</span><span class="p">.</span><span class="nx">createDocumentFragment</span><span class="p">();</span></div><div class='line' id='LC44'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="k">return</span> <span class="p">(</span></div><div class='line' id='LC45'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="k">typeof</span> <span class="nx">frag</span><span class="p">.</span><span class="nx">cloneNode</span> <span class="o">==</span> <span class="s1">&#39;undefined&#39;</span> <span class="o">||</span></div><div class='line' id='LC46'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="k">typeof</span> <span class="nx">frag</span><span class="p">.</span><span class="nx">createDocumentFragment</span> <span class="o">==</span> <span class="s1">&#39;undefined&#39;</span> <span class="o">||</span></div><div class='line' id='LC47'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="k">typeof</span> <span class="nx">frag</span><span class="p">.</span><span class="nx">createElement</span> <span class="o">==</span> <span class="s1">&#39;undefined&#39;</span></div><div class='line' id='LC48'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="p">);</span></div><div class='line' id='LC49'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="p">}());</span></div><div class='line' id='LC50'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="p">}</span> <span class="k">catch</span><span class="p">(</span><span class="nx">e</span><span class="p">)</span> <span class="p">{</span></div><div class='line' id='LC51'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">supportsHtml5Styles</span> <span class="o">=</span> <span class="kc">true</span><span class="p">;</span></div><div class='line' id='LC52'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">supportsUnknownElements</span> <span class="o">=</span> <span class="kc">true</span><span class="p">;</span></div><div class='line' id='LC53'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="p">}</span></div><div class='line' id='LC54'><br/></div><div class='line' id='LC55'>&nbsp;&nbsp;<span class="p">}());</span></div><div class='line' id='LC56'><br/></div><div class='line' id='LC57'>&nbsp;&nbsp;<span class="cm">/*--------------------------------------------------------------------------*/</span></div><div class='line' id='LC58'><br/></div><div class='line' id='LC59'>&nbsp;&nbsp;<span class="cm">/**</span></div><div class='line' id='LC60'><span class="cm">   * Creates a style sheet with the given CSS text and adds it to the document.</span></div><div class='line' id='LC61'><span class="cm">   * @private</span></div><div class='line' id='LC62'><span class="cm">   * @param {Document} ownerDocument The document.</span></div><div class='line' id='LC63'><span class="cm">   * @param {String} cssText The CSS text.</span></div><div class='line' id='LC64'><span class="cm">   * @returns {StyleSheet} The style element.</span></div><div class='line' id='LC65'><span class="cm">   */</span></div><div class='line' id='LC66'>&nbsp;&nbsp;<span class="kd">function</span> <span class="nx">addStyleSheet</span><span class="p">(</span><span class="nx">ownerDocument</span><span class="p">,</span> <span class="nx">cssText</span><span class="p">)</span> <span class="p">{</span></div><div class='line' id='LC67'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="kd">var</span> <span class="nx">p</span> <span class="o">=</span> <span class="nx">ownerDocument</span><span class="p">.</span><span class="nx">createElement</span><span class="p">(</span><span class="s1">&#39;p&#39;</span><span class="p">),</span></div><div class='line' id='LC68'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">parent</span> <span class="o">=</span> <span class="nx">ownerDocument</span><span class="p">.</span><span class="nx">getElementsByTagName</span><span class="p">(</span><span class="s1">&#39;head&#39;</span><span class="p">)[</span><span class="mi">0</span><span class="p">]</span> <span class="o">||</span> <span class="nx">ownerDocument</span><span class="p">.</span><span class="nx">documentElement</span><span class="p">;</span></div><div class='line' id='LC69'><br/></div><div class='line' id='LC70'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">p</span><span class="p">.</span><span class="nx">innerHTML</span> <span class="o">=</span> <span class="s1">&#39;x&lt;style&gt;&#39;</span> <span class="o">+</span> <span class="nx">cssText</span> <span class="o">+</span> <span class="s1">&#39;&lt;/style&gt;&#39;</span><span class="p">;</span></div><div class='line' id='LC71'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="k">return</span> <span class="nx">parent</span><span class="p">.</span><span class="nx">insertBefore</span><span class="p">(</span><span class="nx">p</span><span class="p">.</span><span class="nx">lastChild</span><span class="p">,</span> <span class="nx">parent</span><span class="p">.</span><span class="nx">firstChild</span><span class="p">);</span></div><div class='line' id='LC72'>&nbsp;&nbsp;<span class="p">}</span></div><div class='line' id='LC73'><br/></div><div class='line' id='LC74'>&nbsp;&nbsp;<span class="cm">/**</span></div><div class='line' id='LC75'><span class="cm">   * Returns the value of `html5.elements` as an array.</span></div><div class='line' id='LC76'><span class="cm">   * @private</span></div><div class='line' id='LC77'><span class="cm">   * @returns {Array} An array of shived element node names.</span></div><div class='line' id='LC78'><span class="cm">   */</span></div><div class='line' id='LC79'>&nbsp;&nbsp;<span class="kd">function</span> <span class="nx">getElements</span><span class="p">()</span> <span class="p">{</span></div><div class='line' id='LC80'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="kd">var</span> <span class="nx">elements</span> <span class="o">=</span> <span class="nx">html5</span><span class="p">.</span><span class="nx">elements</span><span class="p">;</span></div><div class='line' id='LC81'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="k">return</span> <span class="k">typeof</span> <span class="nx">elements</span> <span class="o">==</span> <span class="s1">&#39;string&#39;</span> <span class="o">?</span> <span class="nx">elements</span><span class="p">.</span><span class="nx">split</span><span class="p">(</span><span class="s1">&#39; &#39;</span><span class="p">)</span> <span class="o">:</span> <span class="nx">elements</span><span class="p">;</span></div><div class='line' id='LC82'>&nbsp;&nbsp;<span class="p">}</span></div><div class='line' id='LC83'>&nbsp;&nbsp;</div><div class='line' id='LC84'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="cm">/**</span></div><div class='line' id='LC85'><span class="cm">   * Returns the data associated to the given document</span></div><div class='line' id='LC86'><span class="cm">   * @private</span></div><div class='line' id='LC87'><span class="cm">   * @param {Document} ownerDocument The document.</span></div><div class='line' id='LC88'><span class="cm">   * @returns {Object} An object of data.</span></div><div class='line' id='LC89'><span class="cm">   */</span></div><div class='line' id='LC90'>&nbsp;&nbsp;<span class="kd">function</span> <span class="nx">getExpandoData</span><span class="p">(</span><span class="nx">ownerDocument</span><span class="p">)</span> <span class="p">{</span></div><div class='line' id='LC91'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="kd">var</span> <span class="nx">data</span> <span class="o">=</span> <span class="nx">expandoData</span><span class="p">[</span><span class="nx">ownerDocument</span><span class="p">[</span><span class="nx">expando</span><span class="p">]];</span></div><div class='line' id='LC92'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="k">if</span> <span class="p">(</span><span class="o">!</span><span class="nx">data</span><span class="p">)</span> <span class="p">{</span></div><div class='line' id='LC93'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">data</span> <span class="o">=</span> <span class="p">{};</span></div><div class='line' id='LC94'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">expanID</span><span class="o">++</span><span class="p">;</span></div><div class='line' id='LC95'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">ownerDocument</span><span class="p">[</span><span class="nx">expando</span><span class="p">]</span> <span class="o">=</span> <span class="nx">expanID</span><span class="p">;</span></div><div class='line' id='LC96'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">expandoData</span><span class="p">[</span><span class="nx">expanID</span><span class="p">]</span> <span class="o">=</span> <span class="nx">data</span><span class="p">;</span></div><div class='line' id='LC97'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="p">}</span></div><div class='line' id='LC98'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="k">return</span> <span class="nx">data</span><span class="p">;</span></div><div class='line' id='LC99'>&nbsp;&nbsp;<span class="p">}</span></div><div class='line' id='LC100'><br/></div><div class='line' id='LC101'>&nbsp;&nbsp;<span class="cm">/**</span></div><div class='line' id='LC102'><span class="cm">   * returns a shived element for the given nodeName and document</span></div><div class='line' id='LC103'><span class="cm">   * @memberOf html5</span></div><div class='line' id='LC104'><span class="cm">   * @param {String} nodeName name of the element</span></div><div class='line' id='LC105'><span class="cm">   * @param {Document} ownerDocument The context document.</span></div><div class='line' id='LC106'><span class="cm">   * @returns {Object} The shived element.</span></div><div class='line' id='LC107'><span class="cm">   */</span></div><div class='line' id='LC108'>&nbsp;&nbsp;<span class="kd">function</span> <span class="nx">createElement</span><span class="p">(</span><span class="nx">nodeName</span><span class="p">,</span> <span class="nx">ownerDocument</span><span class="p">,</span> <span class="nx">data</span><span class="p">){</span></div><div class='line' id='LC109'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="k">if</span> <span class="p">(</span><span class="o">!</span><span class="nx">ownerDocument</span><span class="p">)</span> <span class="p">{</span></div><div class='line' id='LC110'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">ownerDocument</span> <span class="o">=</span> <span class="nb">document</span><span class="p">;</span></div><div class='line' id='LC111'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="p">}</span></div><div class='line' id='LC112'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="k">if</span><span class="p">(</span><span class="nx">supportsUnknownElements</span><span class="p">){</span></div><div class='line' id='LC113'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="k">return</span> <span class="nx">ownerDocument</span><span class="p">.</span><span class="nx">createElement</span><span class="p">(</span><span class="nx">nodeName</span><span class="p">);</span></div><div class='line' id='LC114'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="p">}</span></div><div class='line' id='LC115'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="k">if</span> <span class="p">(</span><span class="o">!</span><span class="nx">data</span><span class="p">)</span> <span class="p">{</span></div><div class='line' id='LC116'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">data</span> <span class="o">=</span> <span class="nx">getExpandoData</span><span class="p">(</span><span class="nx">ownerDocument</span><span class="p">);</span></div><div class='line' id='LC117'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="p">}</span></div><div class='line' id='LC118'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="kd">var</span> <span class="nx">node</span><span class="p">;</span></div><div class='line' id='LC119'><br/></div><div class='line' id='LC120'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="k">if</span> <span class="p">(</span><span class="nx">data</span><span class="p">.</span><span class="nx">cache</span><span class="p">[</span><span class="nx">nodeName</span><span class="p">])</span> <span class="p">{</span></div><div class='line' id='LC121'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">node</span> <span class="o">=</span> <span class="nx">data</span><span class="p">.</span><span class="nx">cache</span><span class="p">[</span><span class="nx">nodeName</span><span class="p">].</span><span class="nx">cloneNode</span><span class="p">();</span></div><div class='line' id='LC122'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="p">}</span> <span class="k">else</span> <span class="k">if</span> <span class="p">(</span><span class="nx">saveClones</span><span class="p">.</span><span class="nx">test</span><span class="p">(</span><span class="nx">nodeName</span><span class="p">))</span> <span class="p">{</span></div><div class='line' id='LC123'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">node</span> <span class="o">=</span> <span class="p">(</span><span class="nx">data</span><span class="p">.</span><span class="nx">cache</span><span class="p">[</span><span class="nx">nodeName</span><span class="p">]</span> <span class="o">=</span> <span class="nx">data</span><span class="p">.</span><span class="nx">createElem</span><span class="p">(</span><span class="nx">nodeName</span><span class="p">)).</span><span class="nx">cloneNode</span><span class="p">();</span></div><div class='line' id='LC124'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="p">}</span> <span class="k">else</span> <span class="p">{</span></div><div class='line' id='LC125'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">node</span> <span class="o">=</span> <span class="nx">data</span><span class="p">.</span><span class="nx">createElem</span><span class="p">(</span><span class="nx">nodeName</span><span class="p">);</span></div><div class='line' id='LC126'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="p">}</span></div><div class='line' id='LC127'><br/></div><div class='line' id='LC128'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="c1">// Avoid adding some elements to fragments in IE &lt; 9 because</span></div><div class='line' id='LC129'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="c1">// * Attributes like `name` or `type` cannot be set/changed once an element</span></div><div class='line' id='LC130'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="c1">//   is inserted into a document/fragment</span></div><div class='line' id='LC131'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="c1">// * Link elements with `src` attributes that are inaccessible, as with</span></div><div class='line' id='LC132'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="c1">//   a 403 response, will cause the tab/window to crash</span></div><div class='line' id='LC133'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="c1">// * Script elements appended to fragments will execute when their `src`</span></div><div class='line' id='LC134'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="c1">//   or `text` property is set</span></div><div class='line' id='LC135'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="k">return</span> <span class="nx">node</span><span class="p">.</span><span class="nx">canHaveChildren</span> <span class="o">&amp;&amp;</span> <span class="o">!</span><span class="nx">reSkip</span><span class="p">.</span><span class="nx">test</span><span class="p">(</span><span class="nx">nodeName</span><span class="p">)</span> <span class="o">?</span> <span class="nx">data</span><span class="p">.</span><span class="nx">frag</span><span class="p">.</span><span class="nx">appendChild</span><span class="p">(</span><span class="nx">node</span><span class="p">)</span> <span class="o">:</span> <span class="nx">node</span><span class="p">;</span></div><div class='line' id='LC136'>&nbsp;&nbsp;<span class="p">}</span></div><div class='line' id='LC137'><br/></div><div class='line' id='LC138'>&nbsp;&nbsp;<span class="cm">/**</span></div><div class='line' id='LC139'><span class="cm">   * returns a shived DocumentFragment for the given document</span></div><div class='line' id='LC140'><span class="cm">   * @memberOf html5</span></div><div class='line' id='LC141'><span class="cm">   * @param {Document} ownerDocument The context document.</span></div><div class='line' id='LC142'><span class="cm">   * @returns {Object} The shived DocumentFragment.</span></div><div class='line' id='LC143'><span class="cm">   */</span></div><div class='line' id='LC144'>&nbsp;&nbsp;<span class="kd">function</span> <span class="nx">createDocumentFragment</span><span class="p">(</span><span class="nx">ownerDocument</span><span class="p">,</span> <span class="nx">data</span><span class="p">){</span></div><div class='line' id='LC145'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="k">if</span> <span class="p">(</span><span class="o">!</span><span class="nx">ownerDocument</span><span class="p">)</span> <span class="p">{</span></div><div class='line' id='LC146'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">ownerDocument</span> <span class="o">=</span> <span class="nb">document</span><span class="p">;</span></div><div class='line' id='LC147'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="p">}</span></div><div class='line' id='LC148'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="k">if</span><span class="p">(</span><span class="nx">supportsUnknownElements</span><span class="p">){</span></div><div class='line' id='LC149'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="k">return</span> <span class="nx">ownerDocument</span><span class="p">.</span><span class="nx">createDocumentFragment</span><span class="p">();</span></div><div class='line' id='LC150'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="p">}</span></div><div class='line' id='LC151'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">data</span> <span class="o">=</span> <span class="nx">data</span> <span class="o">||</span> <span class="nx">getExpandoData</span><span class="p">(</span><span class="nx">ownerDocument</span><span class="p">);</span></div><div class='line' id='LC152'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="kd">var</span> <span class="nx">clone</span> <span class="o">=</span> <span class="nx">data</span><span class="p">.</span><span class="nx">frag</span><span class="p">.</span><span class="nx">cloneNode</span><span class="p">(),</span></div><div class='line' id='LC153'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">i</span> <span class="o">=</span> <span class="mi">0</span><span class="p">,</span></div><div class='line' id='LC154'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">elems</span> <span class="o">=</span> <span class="nx">getElements</span><span class="p">(),</span></div><div class='line' id='LC155'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">l</span> <span class="o">=</span> <span class="nx">elems</span><span class="p">.</span><span class="nx">length</span><span class="p">;</span></div><div class='line' id='LC156'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="k">for</span><span class="p">(;</span><span class="nx">i</span><span class="o">&lt;</span><span class="nx">l</span><span class="p">;</span><span class="nx">i</span><span class="o">++</span><span class="p">){</span></div><div class='line' id='LC157'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">clone</span><span class="p">.</span><span class="nx">createElement</span><span class="p">(</span><span class="nx">elems</span><span class="p">[</span><span class="nx">i</span><span class="p">]);</span></div><div class='line' id='LC158'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="p">}</span></div><div class='line' id='LC159'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="k">return</span> <span class="nx">clone</span><span class="p">;</span></div><div class='line' id='LC160'>&nbsp;&nbsp;<span class="p">}</span></div><div class='line' id='LC161'><br/></div><div class='line' id='LC162'>&nbsp;&nbsp;<span class="cm">/**</span></div><div class='line' id='LC163'><span class="cm">   * Shivs the `createElement` and `createDocumentFragment` methods of the document.</span></div><div class='line' id='LC164'><span class="cm">   * @private</span></div><div class='line' id='LC165'><span class="cm">   * @param {Document|DocumentFragment} ownerDocument The document.</span></div><div class='line' id='LC166'><span class="cm">   * @param {Object} data of the document.</span></div><div class='line' id='LC167'><span class="cm">   */</span></div><div class='line' id='LC168'>&nbsp;&nbsp;<span class="kd">function</span> <span class="nx">shivMethods</span><span class="p">(</span><span class="nx">ownerDocument</span><span class="p">,</span> <span class="nx">data</span><span class="p">)</span> <span class="p">{</span></div><div class='line' id='LC169'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="k">if</span> <span class="p">(</span><span class="o">!</span><span class="nx">data</span><span class="p">.</span><span class="nx">cache</span><span class="p">)</span> <span class="p">{</span></div><div class='line' id='LC170'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">data</span><span class="p">.</span><span class="nx">cache</span> <span class="o">=</span> <span class="p">{};</span></div><div class='line' id='LC171'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">data</span><span class="p">.</span><span class="nx">createElem</span> <span class="o">=</span> <span class="nx">ownerDocument</span><span class="p">.</span><span class="nx">createElement</span><span class="p">;</span></div><div class='line' id='LC172'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">data</span><span class="p">.</span><span class="nx">createFrag</span> <span class="o">=</span> <span class="nx">ownerDocument</span><span class="p">.</span><span class="nx">createDocumentFragment</span><span class="p">;</span></div><div class='line' id='LC173'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">data</span><span class="p">.</span><span class="nx">frag</span> <span class="o">=</span> <span class="nx">data</span><span class="p">.</span><span class="nx">createFrag</span><span class="p">();</span></div><div class='line' id='LC174'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="p">}</span></div><div class='line' id='LC175'><br/></div><div class='line' id='LC176'><br/></div><div class='line' id='LC177'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">ownerDocument</span><span class="p">.</span><span class="nx">createElement</span> <span class="o">=</span> <span class="kd">function</span><span class="p">(</span><span class="nx">nodeName</span><span class="p">)</span> <span class="p">{</span></div><div class='line' id='LC178'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="c1">//abort shiv</span></div><div class='line' id='LC179'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="k">if</span> <span class="p">(</span><span class="o">!</span><span class="nx">html5</span><span class="p">.</span><span class="nx">shivMethods</span><span class="p">)</span> <span class="p">{</span></div><div class='line' id='LC180'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="k">return</span> <span class="nx">data</span><span class="p">.</span><span class="nx">createElem</span><span class="p">(</span><span class="nx">nodeName</span><span class="p">);</span></div><div class='line' id='LC181'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="p">}</span></div><div class='line' id='LC182'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="k">return</span> <span class="nx">createElement</span><span class="p">(</span><span class="nx">nodeName</span><span class="p">,</span> <span class="nx">ownerDocument</span><span class="p">,</span> <span class="nx">data</span><span class="p">);</span></div><div class='line' id='LC183'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="p">};</span></div><div class='line' id='LC184'><br/></div><div class='line' id='LC185'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">ownerDocument</span><span class="p">.</span><span class="nx">createDocumentFragment</span> <span class="o">=</span> <span class="nb">Function</span><span class="p">(</span><span class="s1">&#39;h,f&#39;</span><span class="p">,</span> <span class="s1">&#39;return function(){&#39;</span> <span class="o">+</span></div><div class='line' id='LC186'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="s1">&#39;var n=f.cloneNode(),c=n.createElement;&#39;</span> <span class="o">+</span></div><div class='line' id='LC187'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="s1">&#39;h.shivMethods&amp;&amp;(&#39;</span> <span class="o">+</span></div><div class='line' id='LC188'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="c1">// unroll the `createElement` calls</span></div><div class='line' id='LC189'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">getElements</span><span class="p">().</span><span class="nx">join</span><span class="p">().</span><span class="nx">replace</span><span class="p">(</span><span class="sr">/\w+/g</span><span class="p">,</span> <span class="kd">function</span><span class="p">(</span><span class="nx">nodeName</span><span class="p">)</span> <span class="p">{</span></div><div class='line' id='LC190'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">data</span><span class="p">.</span><span class="nx">createElem</span><span class="p">(</span><span class="nx">nodeName</span><span class="p">);</span></div><div class='line' id='LC191'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">data</span><span class="p">.</span><span class="nx">frag</span><span class="p">.</span><span class="nx">createElement</span><span class="p">(</span><span class="nx">nodeName</span><span class="p">);</span></div><div class='line' id='LC192'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="k">return</span> <span class="s1">&#39;c(&quot;&#39;</span> <span class="o">+</span> <span class="nx">nodeName</span> <span class="o">+</span> <span class="s1">&#39;&quot;)&#39;</span><span class="p">;</span></div><div class='line' id='LC193'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="p">})</span> <span class="o">+</span></div><div class='line' id='LC194'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="s1">&#39;);return n}&#39;</span></div><div class='line' id='LC195'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="p">)(</span><span class="nx">html5</span><span class="p">,</span> <span class="nx">data</span><span class="p">.</span><span class="nx">frag</span><span class="p">);</span></div><div class='line' id='LC196'>&nbsp;&nbsp;<span class="p">}</span></div><div class='line' id='LC197'><br/></div><div class='line' id='LC198'>&nbsp;&nbsp;<span class="cm">/*--------------------------------------------------------------------------*/</span></div><div class='line' id='LC199'><br/></div><div class='line' id='LC200'>&nbsp;&nbsp;<span class="cm">/**</span></div><div class='line' id='LC201'><span class="cm">   * Shivs the given document.</span></div><div class='line' id='LC202'><span class="cm">   * @memberOf html5</span></div><div class='line' id='LC203'><span class="cm">   * @param {Document} ownerDocument The document to shiv.</span></div><div class='line' id='LC204'><span class="cm">   * @returns {Document} The shived document.</span></div><div class='line' id='LC205'><span class="cm">   */</span></div><div class='line' id='LC206'>&nbsp;&nbsp;<span class="kd">function</span> <span class="nx">shivDocument</span><span class="p">(</span><span class="nx">ownerDocument</span><span class="p">)</span> <span class="p">{</span></div><div class='line' id='LC207'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="k">if</span> <span class="p">(</span><span class="o">!</span><span class="nx">ownerDocument</span><span class="p">)</span> <span class="p">{</span></div><div class='line' id='LC208'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">ownerDocument</span> <span class="o">=</span> <span class="nb">document</span><span class="p">;</span></div><div class='line' id='LC209'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="p">}</span></div><div class='line' id='LC210'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="kd">var</span> <span class="nx">data</span> <span class="o">=</span> <span class="nx">getExpandoData</span><span class="p">(</span><span class="nx">ownerDocument</span><span class="p">);</span></div><div class='line' id='LC211'><br/></div><div class='line' id='LC212'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="k">if</span> <span class="p">(</span><span class="nx">html5</span><span class="p">.</span><span class="nx">shivCSS</span> <span class="o">&amp;&amp;</span> <span class="o">!</span><span class="nx">supportsHtml5Styles</span> <span class="o">&amp;&amp;</span> <span class="o">!</span><span class="nx">data</span><span class="p">.</span><span class="nx">hasCSS</span><span class="p">)</span> <span class="p">{</span></div><div class='line' id='LC213'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">data</span><span class="p">.</span><span class="nx">hasCSS</span> <span class="o">=</span> <span class="o">!!</span><span class="nx">addStyleSheet</span><span class="p">(</span><span class="nx">ownerDocument</span><span class="p">,</span></div><div class='line' id='LC214'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="c1">// corrects block display not defined in IE6/7/8/9</span></div><div class='line' id='LC215'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="s1">&#39;article,aside,figcaption,figure,footer,header,hgroup,nav,section{display:block}&#39;</span> <span class="o">+</span></div><div class='line' id='LC216'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="c1">// adds styling not present in IE6/7/8/9</span></div><div class='line' id='LC217'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="s1">&#39;mark{background:#FF0;color:#000}&#39;</span></div><div class='line' id='LC218'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="p">);</span></div><div class='line' id='LC219'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="p">}</span></div><div class='line' id='LC220'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="k">if</span> <span class="p">(</span><span class="o">!</span><span class="nx">supportsUnknownElements</span><span class="p">)</span> <span class="p">{</span></div><div class='line' id='LC221'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">shivMethods</span><span class="p">(</span><span class="nx">ownerDocument</span><span class="p">,</span> <span class="nx">data</span><span class="p">);</span></div><div class='line' id='LC222'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="p">}</span></div><div class='line' id='LC223'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="k">return</span> <span class="nx">ownerDocument</span><span class="p">;</span></div><div class='line' id='LC224'>&nbsp;&nbsp;<span class="p">}</span></div><div class='line' id='LC225'><br/></div><div class='line' id='LC226'>&nbsp;&nbsp;<span class="cm">/*--------------------------------------------------------------------------*/</span></div><div class='line' id='LC227'><br/></div><div class='line' id='LC228'>&nbsp;&nbsp;<span class="cm">/**</span></div><div class='line' id='LC229'><span class="cm">   * The `html5` object is exposed so that more elements can be shived and</span></div><div class='line' id='LC230'><span class="cm">   * existing shiving can be detected on iframes.</span></div><div class='line' id='LC231'><span class="cm">   * @type Object</span></div><div class='line' id='LC232'><span class="cm">   * @example</span></div><div class='line' id='LC233'><span class="cm">   *</span></div><div class='line' id='LC234'><span class="cm">   * // options can be changed before the script is included</span></div><div class='line' id='LC235'><span class="cm">   * html5 = { &#39;elements&#39;: &#39;mark section&#39;, &#39;shivCSS&#39;: false, &#39;shivMethods&#39;: false };</span></div><div class='line' id='LC236'><span class="cm">   */</span></div><div class='line' id='LC237'>&nbsp;&nbsp;<span class="kd">var</span> <span class="nx">html5</span> <span class="o">=</span> <span class="p">{</span></div><div class='line' id='LC238'><br/></div><div class='line' id='LC239'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="cm">/**</span></div><div class='line' id='LC240'><span class="cm">     * An array or space separated string of node names of the elements to shiv.</span></div><div class='line' id='LC241'><span class="cm">     * @memberOf html5</span></div><div class='line' id='LC242'><span class="cm">     * @type Array|String</span></div><div class='line' id='LC243'><span class="cm">     */</span></div><div class='line' id='LC244'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="s1">&#39;elements&#39;</span><span class="o">:</span> <span class="nx">options</span><span class="p">.</span><span class="nx">elements</span> <span class="o">||</span> <span class="s1">&#39;abbr article aside audio bdi canvas data datalist details figcaption figure footer header hgroup mark meter nav output progress section summary time video&#39;</span><span class="p">,</span></div><div class='line' id='LC245'><br/></div><div class='line' id='LC246'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="cm">/**</span></div><div class='line' id='LC247'><span class="cm">     * current version of html5shiv</span></div><div class='line' id='LC248'><span class="cm">     */</span></div><div class='line' id='LC249'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="s1">&#39;version&#39;</span><span class="o">:</span> <span class="nx">version</span><span class="p">,</span></div><div class='line' id='LC250'><br/></div><div class='line' id='LC251'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="cm">/**</span></div><div class='line' id='LC252'><span class="cm">     * A flag to indicate that the HTML5 style sheet should be inserted.</span></div><div class='line' id='LC253'><span class="cm">     * @memberOf html5</span></div><div class='line' id='LC254'><span class="cm">     * @type Boolean</span></div><div class='line' id='LC255'><span class="cm">     */</span></div><div class='line' id='LC256'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="s1">&#39;shivCSS&#39;</span><span class="o">:</span> <span class="p">(</span><span class="nx">options</span><span class="p">.</span><span class="nx">shivCSS</span> <span class="o">!==</span> <span class="kc">false</span><span class="p">),</span></div><div class='line' id='LC257'><br/></div><div class='line' id='LC258'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="cm">/**</span></div><div class='line' id='LC259'><span class="cm">     * Is equal to true if a browser supports creating unknown/HTML5 elements</span></div><div class='line' id='LC260'><span class="cm">     * @memberOf html5</span></div><div class='line' id='LC261'><span class="cm">     * @type boolean</span></div><div class='line' id='LC262'><span class="cm">     */</span></div><div class='line' id='LC263'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="s1">&#39;supportsUnknownElements&#39;</span><span class="o">:</span> <span class="nx">supportsUnknownElements</span><span class="p">,</span></div><div class='line' id='LC264'><br/></div><div class='line' id='LC265'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="cm">/**</span></div><div class='line' id='LC266'><span class="cm">     * A flag to indicate that the document&#39;s `createElement` and `createDocumentFragment`</span></div><div class='line' id='LC267'><span class="cm">     * methods should be overwritten.</span></div><div class='line' id='LC268'><span class="cm">     * @memberOf html5</span></div><div class='line' id='LC269'><span class="cm">     * @type Boolean</span></div><div class='line' id='LC270'><span class="cm">     */</span></div><div class='line' id='LC271'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="s1">&#39;shivMethods&#39;</span><span class="o">:</span> <span class="p">(</span><span class="nx">options</span><span class="p">.</span><span class="nx">shivMethods</span> <span class="o">!==</span> <span class="kc">false</span><span class="p">),</span></div><div class='line' id='LC272'><br/></div><div class='line' id='LC273'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="cm">/**</span></div><div class='line' id='LC274'><span class="cm">     * A string to describe the type of `html5` object (&quot;default&quot; or &quot;default print&quot;).</span></div><div class='line' id='LC275'><span class="cm">     * @memberOf html5</span></div><div class='line' id='LC276'><span class="cm">     * @type String</span></div><div class='line' id='LC277'><span class="cm">     */</span></div><div class='line' id='LC278'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="s1">&#39;type&#39;</span><span class="o">:</span> <span class="s1">&#39;default&#39;</span><span class="p">,</span></div><div class='line' id='LC279'><br/></div><div class='line' id='LC280'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="c1">// shivs the document according to the specified `html5` object options</span></div><div class='line' id='LC281'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="s1">&#39;shivDocument&#39;</span><span class="o">:</span> <span class="nx">shivDocument</span><span class="p">,</span></div><div class='line' id='LC282'><br/></div><div class='line' id='LC283'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="c1">//creates a shived element</span></div><div class='line' id='LC284'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">createElement</span><span class="o">:</span> <span class="nx">createElement</span><span class="p">,</span></div><div class='line' id='LC285'><br/></div><div class='line' id='LC286'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="c1">//creates a shived documentFragment</span></div><div class='line' id='LC287'>&nbsp;&nbsp;&nbsp;&nbsp;<span class="nx">createDocumentFragment</span><span class="o">:</span> <span class="nx">createDocumentFragment</span></div><div class='line' id='LC288'>&nbsp;&nbsp;<span class="p">};</span></div><div class='line' id='LC289'><br/></div><div class='line' id='LC290'>&nbsp;&nbsp;<span class="cm">/*--------------------------------------------------------------------------*/</span></div><div class='line' id='LC291'><br/></div><div class='line' id='LC292'>&nbsp;&nbsp;<span class="c1">// expose html5</span></div><div class='line' id='LC293'>&nbsp;&nbsp;<span class="nb">window</span><span class="p">.</span><span class="nx">html5</span> <span class="o">=</span> <span class="nx">html5</span><span class="p">;</span></div><div class='line' id='LC294'><br/></div><div class='line' id='LC295'>&nbsp;&nbsp;<span class="c1">// shiv the document</span></div><div class='line' id='LC296'>&nbsp;&nbsp;<span class="nx">shivDocument</span><span class="p">(</span><span class="nb">document</span><span class="p">);</span></div><div class='line' id='LC297'><br/></div><div class='line' id='LC298'><span class="p">}(</span><span class="k">this</span><span class="p">,</span> <span class="nb">document</span><span class="p">));</span></div></pre></div>
          </td>
        </tr>
      </table>
  </div>

          </div>
        </div>
      </div>

      <a href="#jump-to-line" rel="facebox" data-hotkey="l" class="js-jump-to-line" style="display:none">Jump to Line</a>
      <div id="jump-to-line" style="display:none">
        <h2>Jump to Line</h2>
        <form accept-charset="UTF-8" class="js-jump-to-line-form">
          <input class="textfield js-jump-to-line-field" type="text">
          <div class="full-button">
            <button type="submit" class="classy">
              Go
            </button>
          </div>
        </form>
      </div>

    </div>
</div>

<div class="frame frame-loading large-loading-area" style="display:none;">
  <img src="https://a248.e.akamai.net/assets.github.com/images/spinners/octocat-spinner-128.gif?1347543527" height="64" width="64">
</div>

        </div>
      </div>
      <div class="context-overlay"></div>
    </div>

      <div id="footer-push"></div><!-- hack for sticky footer -->
    </div><!-- end of wrapper - hack for sticky footer -->

      <!-- footer -->
      <div id="footer">
  <div class="container clearfix">

      <dl class="footer_nav">
        <dt>GitHub</dt>
        <dd><a href="https://github.com/about">About us</a></dd>
        <dd><a href="https://github.com/blog">Blog</a></dd>
        <dd><a href="https://github.com/contact">Contact &amp; support</a></dd>
        <dd><a href="http://enterprise.github.com/">GitHub Enterprise</a></dd>
        <dd><a href="http://status.github.com/">Site status</a></dd>
      </dl>

      <dl class="footer_nav">
        <dt>Applications</dt>
        <dd><a href="http://mac.github.com/">GitHub for Mac</a></dd>
        <dd><a href="http://windows.github.com/">GitHub for Windows</a></dd>
        <dd><a href="http://eclipse.github.com/">GitHub for Eclipse</a></dd>
        <dd><a href="http://mobile.github.com/">GitHub mobile apps</a></dd>
      </dl>

      <dl class="footer_nav">
        <dt>Services</dt>
        <dd><a href="http://get.gaug.es/">Gauges: Web analytics</a></dd>
        <dd><a href="http://speakerdeck.com">Speaker Deck: Presentations</a></dd>
        <dd><a href="https://gist.github.com">Gist: Code snippets</a></dd>
        <dd><a href="http://jobs.github.com/">Job board</a></dd>
      </dl>

      <dl class="footer_nav">
        <dt>Documentation</dt>
        <dd><a href="http://help.github.com/">GitHub Help</a></dd>
        <dd><a href="http://developer.github.com/">Developer API</a></dd>
        <dd><a href="http://github.github.com/github-flavored-markdown/">GitHub Flavored Markdown</a></dd>
        <dd><a href="http://pages.github.com/">GitHub Pages</a></dd>
      </dl>

      <dl class="footer_nav">
        <dt>More</dt>
        <dd><a href="http://training.github.com/">Training</a></dd>
        <dd><a href="https://github.com/edu">Students &amp; teachers</a></dd>
        <dd><a href="http://shop.github.com">The Shop</a></dd>
        <dd><a href="http://octodex.github.com/">The Octodex</a></dd>
      </dl>

      <hr class="footer-divider">


    <p class="right">&copy; 2012 <span title="0.05849s from fe16.rs.github.com">GitHub</span> Inc. All rights reserved.</p>
    <a class="left" href="https://github.com/">
      <span class="mega-icon mega-icon-invertocat"></span>
    </a>
    <ul id="legal">
        <li><a href="https://github.com/site/terms">Terms of Service</a></li>
        <li><a href="https://github.com/site/privacy">Privacy</a></li>
        <li><a href="https://github.com/security">Security</a></li>
    </ul>

  </div><!-- /.container -->

</div><!-- /.#footer -->


    

<div id="keyboard_shortcuts_pane" class="instapaper_ignore readability-extra" style="display:none">
  <h2>Keyboard Shortcuts <small><a href="#" class="js-see-all-keyboard-shortcuts">(see all)</a></small></h2>

  <div class="columns threecols">
    <div class="column first">
      <h3>Site wide shortcuts</h3>
      <dl class="keyboard-mappings">
        <dt>s</dt>
        <dd>Focus command bar</dd>
      </dl>
      <dl class="keyboard-mappings">
        <dt>?</dt>
        <dd>Bring up this help dialog</dd>
      </dl>
    </div><!-- /.column.first -->

    <div class="column middle" style='display:none'>
      <h3>Commit list</h3>
      <dl class="keyboard-mappings">
        <dt>j</dt>
        <dd>Move selection down</dd>
      </dl>
      <dl class="keyboard-mappings">
        <dt>k</dt>
        <dd>Move selection up</dd>
      </dl>
      <dl class="keyboard-mappings">
        <dt>c <em>or</em> o <em>or</em> enter</dt>
        <dd>Open commit</dd>
      </dl>
      <dl class="keyboard-mappings">
        <dt>y</dt>
        <dd>Expand URL to its canonical form</dd>
      </dl>
    </div><!-- /.column.first -->

    <div class="column last js-hidden-pane" style='display:none'>
      <h3>Pull request list</h3>
      <dl class="keyboard-mappings">
        <dt>j</dt>
        <dd>Move selection down</dd>
      </dl>
      <dl class="keyboard-mappings">
        <dt>k</dt>
        <dd>Move selection up</dd>
      </dl>
      <dl class="keyboard-mappings">
        <dt>o <em>or</em> enter</dt>
        <dd>Open issue</dd>
      </dl>
      <dl class="keyboard-mappings">
        <dt><span class="platform-mac">⌘</span><span class="platform-other">ctrl</span> <em>+</em> enter</dt>
        <dd>Submit comment</dd>
      </dl>
      <dl class="keyboard-mappings">
        <dt><span class="platform-mac">⌘</span><span class="platform-other">ctrl</span> <em>+</em> shift p</dt>
        <dd>Preview comment</dd>
      </dl>
    </div><!-- /.columns.last -->

  </div><!-- /.columns.equacols -->

  <div class="js-hidden-pane" style='display:none'>
    <div class="rule"></div>

    <h3>Issues</h3>

    <div class="columns threecols">
      <div class="column first">
        <dl class="keyboard-mappings">
          <dt>j</dt>
          <dd>Move selection down</dd>
        </dl>
        <dl class="keyboard-mappings">
          <dt>k</dt>
          <dd>Move selection up</dd>
        </dl>
        <dl class="keyboard-mappings">
          <dt>x</dt>
          <dd>Toggle selection</dd>
        </dl>
        <dl class="keyboard-mappings">
          <dt>o <em>or</em> enter</dt>
          <dd>Open issue</dd>
        </dl>
        <dl class="keyboard-mappings">
          <dt><span class="platform-mac">⌘</span><span class="platform-other">ctrl</span> <em>+</em> enter</dt>
          <dd>Submit comment</dd>
        </dl>
        <dl class="keyboard-mappings">
          <dt><span class="platform-mac">⌘</span><span class="platform-other">ctrl</span> <em>+</em> shift p</dt>
          <dd>Preview comment</dd>
        </dl>
      </div><!-- /.column.first -->
      <div class="column last">
        <dl class="keyboard-mappings">
          <dt>c</dt>
          <dd>Create issue</dd>
        </dl>
        <dl class="keyboard-mappings">
          <dt>l</dt>
          <dd>Create label</dd>
        </dl>
        <dl class="keyboard-mappings">
          <dt>i</dt>
          <dd>Back to inbox</dd>
        </dl>
        <dl class="keyboard-mappings">
          <dt>u</dt>
          <dd>Back to issues</dd>
        </dl>
        <dl class="keyboard-mappings">
          <dt>/</dt>
          <dd>Focus issues search</dd>
        </dl>
      </div>
    </div>
  </div>

  <div class="js-hidden-pane" style='display:none'>
    <div class="rule"></div>

    <h3>Issues Dashboard</h3>

    <div class="columns threecols">
      <div class="column first">
        <dl class="keyboard-mappings">
          <dt>j</dt>
          <dd>Move selection down</dd>
        </dl>
        <dl class="keyboard-mappings">
          <dt>k</dt>
          <dd>Move selection up</dd>
        </dl>
        <dl class="keyboard-mappings">
          <dt>o <em>or</em> enter</dt>
          <dd>Open issue</dd>
        </dl>
      </div><!-- /.column.first -->
    </div>
  </div>

  <div class="js-hidden-pane" style='display:none'>
    <div class="rule"></div>

    <h3>Network Graph</h3>
    <div class="columns equacols">
      <div class="column first">
        <dl class="keyboard-mappings">
          <dt><span class="badmono">←</span> <em>or</em> h</dt>
          <dd>Scroll left</dd>
        </dl>
        <dl class="keyboard-mappings">
          <dt><span class="badmono">→</span> <em>or</em> l</dt>
          <dd>Scroll right</dd>
        </dl>
        <dl class="keyboard-mappings">
          <dt><span class="badmono">↑</span> <em>or</em> k</dt>
          <dd>Scroll up</dd>
        </dl>
        <dl class="keyboard-mappings">
          <dt><span class="badmono">↓</span> <em>or</em> j</dt>
          <dd>Scroll down</dd>
        </dl>
        <dl class="keyboard-mappings">
          <dt>t</dt>
          <dd>Toggle visibility of head labels</dd>
        </dl>
      </div><!-- /.column.first -->
      <div class="column last">
        <dl class="keyboard-mappings">
          <dt>shift <span class="badmono">←</span> <em>or</em> shift h</dt>
          <dd>Scroll all the way left</dd>
        </dl>
        <dl class="keyboard-mappings">
          <dt>shift <span class="badmono">→</span> <em>or</em> shift l</dt>
          <dd>Scroll all the way right</dd>
        </dl>
        <dl class="keyboard-mappings">
          <dt>shift <span class="badmono">↑</span> <em>or</em> shift k</dt>
          <dd>Scroll all the way up</dd>
        </dl>
        <dl class="keyboard-mappings">
          <dt>shift <span class="badmono">↓</span> <em>or</em> shift j</dt>
          <dd>Scroll all the way down</dd>
        </dl>
      </div><!-- /.column.last -->
    </div>
  </div>

  <div class="js-hidden-pane" >
    <div class="rule"></div>
    <div class="columns threecols">
      <div class="column first js-hidden-pane" >
        <h3>Source Code Browsing</h3>
        <dl class="keyboard-mappings">
          <dt>t</dt>
          <dd>Activates the file finder</dd>
        </dl>
        <dl class="keyboard-mappings">
          <dt>l</dt>
          <dd>Jump to line</dd>
        </dl>
        <dl class="keyboard-mappings">
          <dt>w</dt>
          <dd>Switch branch/tag</dd>
        </dl>
        <dl class="keyboard-mappings">
          <dt>y</dt>
          <dd>Expand URL to its canonical form</dd>
        </dl>
      </div>
    </div>
  </div>

  <div class="js-hidden-pane" style='display:none'>
    <div class="rule"></div>
    <div class="columns threecols">
      <div class="column first">
        <h3>Browsing Commits</h3>
        <dl class="keyboard-mappings">
          <dt><span class="platform-mac">⌘</span><span class="platform-other">ctrl</span> <em>+</em> enter</dt>
          <dd>Submit comment</dd>
        </dl>
        <dl class="keyboard-mappings">
          <dt>escape</dt>
          <dd>Close form</dd>
        </dl>
        <dl class="keyboard-mappings">
          <dt>p</dt>
          <dd>Parent commit</dd>
        </dl>
        <dl class="keyboard-mappings">
          <dt>o</dt>
          <dd>Other parent commit</dd>
        </dl>
      </div>
    </div>
  </div>

  <div class="js-hidden-pane" style='display:none'>
    <div class="rule"></div>
    <h3>Notifications</h3>

    <div class="columns threecols">
      <div class="column first">
        <dl class="keyboard-mappings">
          <dt>j</dt>
          <dd>Move selection down</dd>
        </dl>
        <dl class="keyboard-mappings">
          <dt>k</dt>
          <dd>Move selection up</dd>
        </dl>
        <dl class="keyboard-mappings">
          <dt>o <em>or</em> enter</dt>
          <dd>Open notification</dd>
        </dl>
      </div><!-- /.column.first -->

      <div class="column second">
        <dl class="keyboard-mappings">
          <dt>e <em>or</em> shift i <em>or</em> y</dt>
          <dd>Mark as read</dd>
        </dl>
        <dl class="keyboard-mappings">
          <dt>shift m</dt>
          <dd>Mute thread</dd>
        </dl>
      </div><!-- /.column.first -->
    </div>
  </div>

</div>

    <div id="markdown-help" class="instapaper_ignore readability-extra">
  <h2>Markdown Cheat Sheet</h2>

  <div class="cheatsheet-content">

  <div class="mod">
    <div class="col">
      <h3>Format Text</h3>
      <p>Headers</p>
      <pre>
# This is an &lt;h1&gt; tag
## This is an &lt;h2&gt; tag
###### This is an &lt;h6&gt; tag</pre>
     <p>Text styles</p>
     <pre>
*This text will be italic*
_This will also be italic_
**This text will be bold**
__This will also be bold__

*You **can** combine them*
</pre>
    </div>
    <div class="col">
      <h3>Lists</h3>
      <p>Unordered</p>
      <pre>
* Item 1
* Item 2
  * Item 2a
  * Item 2b</pre>
     <p>Ordered</p>
     <pre>
1. Item 1
2. Item 2
3. Item 3
   * Item 3a
   * Item 3b</pre>
    </div>
    <div class="col">
      <h3>Miscellaneous</h3>
      <p>Images</p>
      <pre>
![GitHub Logo](/images/logo.png)
Format: ![Alt Text](url)
</pre>
     <p>Links</p>
     <pre>
http://github.com - automatic!
[GitHub](http://github.com)</pre>
<p>Blockquotes</p>
     <pre>
As Kanye West said:

> We're living the future so
> the present is our past.
</pre>
    </div>
  </div>
  <div class="rule"></div>

  <h3>Code Examples in Markdown</h3>
  <div class="col">
      <p>Syntax highlighting with <a href="http://github.github.com/github-flavored-markdown/" title="GitHub Flavored Markdown" target="_blank">GFM</a></p>
      <pre>
```javascript
function fancyAlert(arg) {
  if(arg) {
    $.facebox({div:'#foo'})
  }
}
```</pre>
    </div>
    <div class="col">
      <p>Or, indent your code 4 spaces</p>
      <pre>
Here is a Python code example
without syntax highlighting:

    def foo:
      if not bar:
        return true</pre>
    </div>
    <div class="col">
      <p>Inline code for comments</p>
      <pre>
I think you should use an
`&lt;addr&gt;` element here instead.</pre>
    </div>
  </div>

  </div>
</div>


    <div id="ajax-error-message" class="flash flash-error">
      <span class="mini-icon mini-icon-exclamation"></span>
      Something went wrong with that request. Please try again.
      <a href="#" class="mini-icon mini-icon-remove-close ajax-error-dismiss"></a>
    </div>

    
    
    <span id='server_response_time' data-time='0.05971' data-host='fe16'></span>
    
  </body>
</html>

