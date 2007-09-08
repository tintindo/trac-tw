<script type="text/javascript">searchHighlight()</script><?cs
if:len(chrome.links.alternate) ?>
<div id="altlinks"><h3>以其他格式下載:</h3><ul><?cs
 each:link = chrome.links.alternate ?><?cs
  set:isfirst = name(link) == 0 ?><?cs
  set:islast = name(link) == len(chrome.links.alternate) - 1?><li<?cs
    if:isfirst || islast ?> class="<?cs
     if:isfirst ?>first<?cs /if ?><?cs
     if:isfirst && islast ?> <?cs /if ?><?cs
     if:islast ?>last<?cs /if ?>"<?cs
    /if ?>><a href="<?cs var:link.href ?>"<?cs if:link.class ?> class="<?cs
    var:link.class ?>"<?cs /if ?>>
    <?cs if link.title == "Plain Text" ?>文字格式
    <?cs elif link.title == "Comma-delimited Text" ?>CSV文字(逗點分隔)格式
    <?cs elif link.title == "Tab-delimited Text" ?>定位點分隔文字格式
    <?cs elif link.title == "RSS Feed" ?>RSS反饋
    <?cs elif link.title == "SQL Query" ?>SQL查詢
    <?cs else ?><?cs var:link.title ?>
    <?cs /if ?>
    </a></li><?cs
 /each ?></ul></div><?cs
/if ?>

</div>

<div id="footer">
 <hr />
 <a id="tracpowered" href="http://trac.edgewall.org/"><img src="<?cs
   var:htdocs_location ?>trac_logo_mini.png" height="30" width="107"
   alt="Trac Powered"/></a>
 <p class="left">
  Powered by <a href="<?cs var:trac.href.about ?>"><strong>Trac <?cs
  var:trac.version ?></strong></a><br />
  By <a href="http://www.edgewall.org/">Edgewall Software</a>.
 </p>
 <p class="right">
  <?cs var:project.footer ?>
 </p>
</div>

<?cs include "site_footer.cs" ?>
 </body>
</html>
