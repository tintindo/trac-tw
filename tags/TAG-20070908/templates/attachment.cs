<?cs include "header.cs" ?>
<?cs include "macros.cs" ?>

<div id="ctxtnav" class="nav"></div>

<div id="content" class="attachment">

<?cs if:attachment.mode == 'new' ?>
 <h1>加入附件到 <a href="<?cs var:attachment.parent.href?>"><?cs
   var:attachment.parent.name ?></a></h1>
 <form id="attachment" method="post" enctype="multipart/form-data" action="">
  <div class="field">
   <label>檔名:<br /><input type="file" name="attachment" /></label>
  </div>
  <fieldset>
   <legend>附件資訊</legend>
   <?cs if:trac.authname == "anonymous" ?>
    <div class="field">
     <label>您的 email 或帳號:<br />
     <input type="text" name="author" size="30" value="<?cs
       var:attachment.author?>" /></label>
    </div>
   <?cs /if ?>
   <div class="field">
    <label>本檔案的說明 (選項):<br />
    <input type="text" name="description" size="60" /></label>
   </div>
   <br />
   <div class="options">
    <label><input type="checkbox" name="replace" />
    相同的說明要覆蓋原有內容</label>
   </div>
   <br />
  </fieldset>
  <div class="buttons">
   <input type="hidden" name="action" value="new" />
   <input type="hidden" name="type" value="<?cs var:attachment.parent.type ?>" />
   <input type="hidden" name="id" value="<?cs var:attachment.parent.id ?>" />
   <input type="submit" value="加入附件" />
   <input type="submit" name="cancel" value="取消" />
  </div>
 </form>
<?cs elif:attachment.mode == 'delete' ?>
 <h1><a href="<?cs var:attachment.parent.href ?>"><?cs
   var:attachment.parent.name ?></a>: <?cs var:attachment.filename ?></h1>
 <p><strong>確定要刪除此附件嗎？</strong><br />
 本操作無法復原.</p>
 <div class="buttons">
  <form method="post" action=""><div id="delete">
   <input type="hidden" name="action" value="delete" />
   <input type="submit" name="cancel" value="取消" />
   <input type="submit" value="刪除附件" />
  </div></form>
 </div>
<?cs elif:attachment.mode == 'list' ?>
 <h1><a href="<?cs var:attachment.parent.href ?>"><?cs
   var:attachment.parent.name ?></a></h1><?cs
  call:list_of_attachments(attachment.list, attachment.attach_href) ?>
<?cs else ?>
 <h1><a href="<?cs var:attachment.parent.href ?>"><?cs
   var:attachment.parent.name ?></a>: <?cs var:attachment.filename ?></h1>
 <table id="info" summary="Description"><tbody><tr>
   <th scope="col">
    檔案 <?cs var:attachment.filename ?>, <?cs var:attachment.size ?>
    (加入者: <?cs var:attachment.author ?>,  <?cs var:attachment.age ?> 前)
   </th></tr><tr>
   <td class="message"><?cs var:attachment.description ?></td>
  </tr>
 </tbody></table>
 <div id="preview"><?cs
  if:attachment.preview ?>
   <?cs var:attachment.preview ?><?cs
  elif:attachment.max_file_size_reached ?>
   <strong>HTML preview not available</strong>, since the file size exceeds
   <?cs var:attachment.max_file_size  ?> bytes. You may <a href="<?cs
     var:attachment.raw_href ?>">download the file</a> instead.<?cs
  else ?>
   <strong>HTML preview not available</strong>. To view the file,
   <a href="<?cs var:attachment.raw_href ?>">download the file</a>.<?cs
  /if ?>
 </div>
 <?cs if:attachment.can_delete ?><div class="buttons">
  <form method="get" action=""><div id="delete">
   <input type="hidden" name="action" value="delete" />
   <input type="submit" value="刪除附件" />
  </div></form>
 </div><?cs /if ?>
<?cs /if ?>

</div>
<?cs include "footer.cs"?>
